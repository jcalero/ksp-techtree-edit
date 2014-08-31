using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using KSPTechTreeEditor.Properties;

namespace KSPTechTreeEditor
{
	public partial class MainWindow : Form
	{
		private string _treeFile;
		private Tree _tree;
		private TreeParser _tp;
		private ModCollection _mc;
		private ModCollectionParser _mcp;

		public MainWindow()
		{
			InitializeComponent();
		}

		private void MainWindowLoad(object sender, EventArgs e)
		{
			// Load Settings
			if (Settings.Default.TreeLocation != null && File.Exists(Settings.Default.TreeLocation))
			{
				_treeFile = Settings.Default.TreeLocation;
				_buttonTreeLoad.Text = _treeFile;
			}
			var versionNr = Assembly.GetEntryAssembly().GetName().Version;
			Text = string.Format(
								 "{0}{1}.{2}.{3}",
								 Resources.GUI_TitleLabel,
								 versionNr.Major,
								 versionNr.Minor,
								 versionNr.Build);

			// Initialise tree
			if (_treeFile != null) InitialiseTree();
			// Initialise mod collection
			_mcp = new ModCollectionParser(_mc);
			_mcp.Load();
			_mc = _mcp.Collection;

			ReloadCheckList();
		}

		private void InitialiseTree()
		{
			_tp = new TreeParser(_treeFile);
			_tree = _tp.Tree;
		}

		private void ButtonTreeLoadClick(object sender, EventArgs e)
		{
			var result = _openFileDialog1.ShowDialog();
			if (result != DialogResult.OK) return;

			_treeFile = _openFileDialog1.FileName;
			_buttonTreeLoad.Text = _treeFile;
			Settings.Default.TreeLocation = _treeFile;
			InitialiseTree();
			Settings.Default.Save();
		}

		private void AddModToolStripMenuItemClick(object sender, EventArgs e)
		{
			using (var dialog = new AddModDialog())
			{
				var result = dialog.ShowDialog();

				switch (result)
				{
					case DialogResult.OK:
						_mc.AddMod(dialog.ModTitle, ParsePartList(dialog.ModParts), ParsePrefixList(dialog.ModParts));
						_mcp.Collection = _mc;
						ReloadCheckList();
						_mcp.Save();
						break;
				}
			}
		}

		private void ReloadCheckList()
		{
			_checkedListMods.Items.Clear();
			foreach (var mod in _mc.Mods)
			{
				_checkedListMods.Items.Add(mod.Name);
			}
		}

		private static Dictionary<string, string> ParsePartList(string parts)
		{
			return Regex.Split(parts, ",")
						.Where(part => part.Trim().Length >= 1 && part.Trim().Last() != '*')
						.ToDictionary(part => part.Trim(), part => "");
		}

		private static List<string> ParsePrefixList(string prefixes)
		{
			return (from part in Regex.Split(prefixes, ",")
					where part.Trim().Length >= 1 && part.Trim().Last() == '*'
					select part.Trim()).ToList();
		}

		private void EditModToolStripMenuItemClick(object sender, EventArgs e)
		{
			using (var dialog = new EditModDialog())
			{
				dialog.Mc = _mc;

				var result = dialog.ShowDialog();

				switch (result)
				{
					case DialogResult.OK:
						_mc = dialog.Mc;
						_mcp.Collection = dialog.Mc;
						ReloadCheckList();
						_mcp.Save();
						break;
				}
			}
		}

		private void CloseToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void ButtonSaveTreeClick(object sender, EventArgs e)
		{
			_tp.Backup();
			var unCheckedItems = (from object t in _checkedListMods.Items
								  where !_checkedListMods.CheckedItems.Contains(t)
								  select t.ToString()).ToList();

			foreach (var modtitle in unCheckedItems)
			{
				foreach (var mod in _mc.Mods)
				{
					if (mod.Name != modtitle) continue;
					DeletePartsByMod(mod);
					break;
				}
			}
			_mcp.Collection = _mc;
			_mcp.Save();
			_tp.Tree = _tree;
			_tp.Save();
			SetTextByTimer(_labelStatusBar, Resources.STATUSBAR_TreeUpdatedSuccess, 5);
		}

		private void SetTextByTimer(Control label, string text, double seconds)
		{
			label.Text = text;
			var timer = new Timer { Interval = (int) (seconds * 1000) };
			timer.Tick += (s, eventargs) =>
						  {
							  label.Text = "";
							  timer.Stop();
						  };
			timer.Start();
		}

		private void DeletePartsByMod(Mod mod)
		{
			//TODO: Optimise!
			var nodesToEdit = new List<Node>();
			foreach (var modpart in mod.Parts)
			{
				foreach (var node in _tree.Nodes)
				{
					foreach (var part in node.Parts)
					{
						if ((string) part.Value == modpart.Key)
						{
							nodesToEdit.Add(node);
							break;
						}
					}
				}
			}
			foreach (var modprefix in mod.Prefixes)
			{
				foreach (var node in _tree.Nodes)
				{
					foreach (var part in node.Parts)
					{
						if (part.Value.ToString().StartsWith(modprefix.TrimEnd('*')))
						{
							if (!mod.Parts.ContainsKey(part))
								mod.Parts.Add(part, "");
							if (!nodesToEdit.Contains(node))
								nodesToEdit.Add(node);
							break;
						}
					}
				}
			}

			foreach (var node in nodesToEdit)
			{
				node.Parts.RemoveAll(p => mod.Parts.Any(p2 => (string) p.Value == p2.Key));
				node.Parts.RemoveAll(p => mod.Prefixes.Any(p2 => p.Value.ToString().StartsWith(p2.TrimEnd('*'))));
			}
		}

		private void ButtonCheckAllClick(object sender, EventArgs e)
		{
			for (var i = 0; i < _checkedListMods.Items.Count; i++)
			{
				_checkedListMods.SetItemChecked(i, true);
			}
		}

		private void ButtonUncheckAllClick(object sender, EventArgs e)
		{
			for (var i = 0; i < _checkedListMods.Items.Count; i++)
			{
				_checkedListMods.SetItemChecked(i, false);
			}
		}

		private void ButtonRestoreBackupClick(object sender, EventArgs e)
		{
			if (!File.Exists(Settings.Default.BackupLocation))
			{
				SetTextByTimer(_labelStatusBar, Resources.STATUSBAR_Nobackup, 5);
				return;
			}
			_tp.Restore();
			SetTextByTimer(_labelStatusBar, Resources.STATUSBAR_RestoreSuccess, 5);
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {}
	}
}
