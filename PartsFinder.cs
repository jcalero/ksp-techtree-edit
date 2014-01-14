using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AVTTLoaderStandalone
{
    public delegate void ProgressFileSearch(object sender, EventArgs e);

    class PartsFinder
    {
        public event ProgressFileSearch Progress;

        protected virtual void OnProgress()
        {
            var handler = Progress;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        public List<string> Parts { get; private set; }

        public PartsFinder()
        {
            Parts = new List<string>();
        }

        public List<string> FindParts(string directory)
        {
            Parts = new List<string>();
            var dir = new DirectoryInfo(@directory);
            foreach (var file in dir.GetFiles("*.cfg", SearchOption.AllDirectories))
            {
                OnProgress();
                var parts = GetParts(file);
                if (parts != null && parts.Count >= 1)
                {
                    foreach (var p in parts.Where(p => !Parts.Contains(p)))
                    {
                        Parts.Add(p);
                    }
                }
            }
            return Parts;
        }

        public string FindPartsString(string directory)
        {
            return FindParts(directory).Aggregate("", (current, part) => current + (part + ", "));
        }

        static List<string> GetParts(FileSystemInfo file, bool specialCase = false)
        {
            var parts = new List<string>();
            var reader = new StreamReader(file.FullName);
            string line;
            var isPart = false;
            var depth = 0;

            // Special case for part.cfg's that don't have a PART{ } section
            // but instead only the actual attributes are in the file. Apparently
            // that's an accepted file structre :/ Silly Squad...
            if (specialCase)
            {
                isPart = true;
                depth = 1;
            }

            while ((line = reader.ReadLine()) != null)
            {
                line = line.Trim();

                if (line.StartsWith("PART")) isPart = true;

                if (!isPart) continue;
                
                if (line.Contains("{")) depth++;

                if (line.Contains("}")) depth--;

                if (depth != 1) continue;

                if (!line.StartsWith("name = ")) continue;

                var partName = line.Remove(0, line.LastIndexOf(char.Parse("=")) + 1).Trim();
                if (partName.Length >= 1 && !parts.Contains(partName)) parts.Add(partName);
            }
            reader.Close();

            // If no parts found, try special case
            return (parts.Count < 1 && file.Name == "part.cfg") ? GetParts(file, true) : parts;
        }

        public int FilesCount(string directory)
        {
            var dir = new DirectoryInfo(@directory);
            return dir.GetFiles("*.cfg", SearchOption.AllDirectories).Count();
        }
    }
}
