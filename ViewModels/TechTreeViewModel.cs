using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ksp_techtree_edit.ViewModels
{
	public class TechTreeViewModel : NotificationViewModel
	{
		#region Members

		#region Private

		private WorkspaceViewModel _workspaceViewModel;

		public TechTreeViewModel()
		{
			Connections = new ObservableCollection<ConnectionViewModel>();
			TechTree = new ObservableCollection<TechNodeViewModel>();
		}

		#endregion Private

		#region Public

		public ObservableCollection<TechNodeViewModel>
			TechTree { get; private set; }

		public ObservableCollection<ConnectionViewModel>
			Connections { get; private set; }

		public WorkspaceViewModel WorkspaceViewModel
		{
			get { return _workspaceViewModel; }
			set
			{
				if (_workspaceViewModel == value) return;
				_workspaceViewModel = value;
				OnPropertyChanged();
			}
		}

		#endregion Public

		#endregion Members

		#region Methods

		/// <summary>
		/// Searches through the tech tree and creates new connection models
		/// for each child-to-parent relationship. Connection models are stored
		/// in <see cref="Connections"/>.
		/// </summary>
		public void LinkNodes()
		{
			Connections.Clear();

			foreach (var node in TechTree)
				foreach (var parent in node.Parents)
				{
					Connections
						.Add(new ConnectionViewModel(node, parent));
				}
		}

		public void DeleteNode(TechNodeViewModel node)
		{
			TechTree.Remove(node);
			UnlinkParent(node);
			LinkNodes();
		}

		//TODO: Remove this terrible terrible method and replace with proper
		//MVVM model-viewmodel dependencies.
		public void UnlinkParent(TechNodeViewModel parentToRemove)
		{
			foreach (var node in TechTree)
			{
				if (node.Parents.Contains(parentToRemove))
				{
					node.Parents.Remove(parentToRemove);
				}
			}
		}

		public void Save(TreeSaver saver)
		{
			saver.StartTree(this);
			foreach (var node in TechTree)
			{
				var parts = new List<string>();
				foreach (var part in node.Parts)
				{
					parts.Add(part.PartName);
				}
				var parents = new List<string>();
				foreach (var parent in node.Parents)
				{
					parents.Add(parent.NodeName);
				}
				saver.StartNode().
				      SaveAttribute(new KeyValuePair<string, string>("name", node.NodeName)).
				      SaveAttribute(new KeyValuePair<string, string>("techID", node.TechId)).
				      SavePosition(node.Pos.X, node.Pos.Y, node.Zlayer).
				      SaveAttribute(new KeyValuePair<string, string>("icon", node.Icon.ToString())).
				      SaveAttribute(new KeyValuePair<string, string>("cost", node.Cost.ToString(CultureInfo.InvariantCulture))).
				      SaveAttribute(new KeyValuePair<string, string>("title", node.Title)).
				      SaveAttribute(new KeyValuePair<string, string>("description", node.Description)).
				      SaveAttribute(new KeyValuePair<string, string>("anyParent", node.AnyParent.ToString())).
				      SaveAttribute(new KeyValuePair<string, string>("hideIfEmpty", node.HideIfEmpty.ToString())).
				      StartParents().
				      SaveParents(parents).
				      EndParents().
				      StartParts().
				      SaveParts(node.Parts).
				      EndParts().
				      EndNode();
			}
			saver.EndTree();
			saver.Save("../../test.cfg");
		}

		#endregion Methods
	}

	public abstract class TreeSaver
	{
		protected readonly List<string> Output = new List<string>();

		public abstract TreeSaver StartTree(TechTreeViewModel techTree = null);
		public abstract TreeSaver StartNode();
		public abstract TreeSaver SaveAttribute(KeyValuePair<string, string> nameAttributePair);
		public abstract TreeSaver SavePosition(double x, double y, double z);
		public abstract TreeSaver StartParents();
		public abstract TreeSaver SaveParents(IEnumerable<string> parentsList);
		public abstract TreeSaver EndParents();
		public abstract TreeSaver StartParts();
		public abstract TreeSaver SaveParts(IEnumerable<PartViewModel> partsList);
		public abstract TreeSaver EndParts();
		public abstract TreeSaver EndNode();
		public abstract TreeSaver EndTree();

		public void Save(string path)
		{
			File.WriteAllLines(path, Output);
		}
	}

	public class TreeLoaderSaver : TreeSaver
	{
		public override TreeSaver StartTree(TechTreeViewModel techTree = null)
		{
			if (techTree == null) return this;
			var stockNodes = File.ReadAllLines("..//..//stocknodes.kted");
			var nodeNames = new List<string>();

			foreach (var node in techTree.TechTree)
			{
				nodeNames.Add(node.NodeName);
			}

			foreach (var stockNode in stockNodes)
			{
				if (nodeNames.Contains(stockNode)) continue;
				Output.Add("REMOVENODE");
				Output.Add("{");
				Output.Add("	name = " + stockNode);
				Output.Add("}");
			}
			return this;
		}

		public override TreeSaver StartNode()
		{
			Output.Add("NODE");
			Output.Add("{");
			return this;
		}

		public override TreeSaver SaveAttribute(KeyValuePair<string, string> nameAttributePair)
		{
			Output.Add("	" + nameAttributePair.Key + " = " + nameAttributePair.Value);
			return this;
		}

		public override TreeSaver SavePosition(double x, double y, double z)
		{
			var pos = x + "," + y + "," + z;
			Output.Add("	pos = " + pos);
			return this;
		}

		public override TreeSaver StartParents()
		{
			return this;
		}

		public override TreeSaver SaveParents(IEnumerable<string> parentsList)
		{
			var parentsOutput = "";
			var parents = parentsList as string[] ?? parentsList.ToArray();

			for (var i = 0; i < parents.Length; i++)
			{
				parentsOutput += parents[i];
				if (i < parents.Length - 1) parentsOutput += ",";
			}

			Output.Add("	parents = " + parentsOutput);
			return this;
		}

		public override TreeSaver EndParents()
		{
			return this;
		}

		public override TreeSaver EndNode()
		{
			Output.Add("}");
			return this;
		}

		public override TreeSaver StartParts()
		{
			Output.Add("	PARTS");
			Output.Add("	{");
			return this;
		}

		public override TreeSaver SaveParts(IEnumerable<PartViewModel> partsList)
		{
			foreach (var part in partsList)
			{
				Output.Add("		name = " + part.PartName);
			}
			return this;
		}

		public override TreeSaver EndParts()
		{
			Output.Add("	}");
			return this;
		}

		public override TreeSaver EndTree()
		{
			return this;
		}
	}

	public class ATCSaver : TreeSaver
	{
		private readonly List<string> _partsBuffer = new List<string>();

		public override TreeSaver StartTree(TechTreeViewModel techTree = null)
		{
			Output.Add("TECH_TREE");
			Output.Add("{");
			Output.Add("	name = test");
			return this;
		}

		public override TreeSaver StartNode()
		{
			Output.Add("	TECH_NODE");
			Output.Add("	{");
			return this;
		}

		public override TreeSaver SaveAttribute(KeyValuePair<string, string> nameAttributePair)
		{
			var key = nameAttributePair.Key;
			switch (nameAttributePair.Key)
			{
				case "anyParent":
					key = "anyParentUnlocks";
					break;

				case "hideIfEmpty":
					key = "hideIfNoparts";
					break;

				case "cost":
					key = "scienceCost";
					break;
			}
			Output.Add("		" + key + " = " + nameAttributePair.Value);
			return this;
		}

		public override TreeSaver SavePosition(double x, double y, double z)
		{
			Output.Add("		posX = " + x);
			Output.Add("		posY = " + y);
			return this;
		}

		public override TreeSaver StartParents()
		{
			return this;
		}

		public override TreeSaver SaveParents(IEnumerable<string> parentsList)
		{
			var parents = parentsList as string[] ?? parentsList.ToArray();

			foreach (var parent in parents)
			{
				Output.Add("		PARENT_NODE");
				Output.Add("		{");
				Output.Add("			name = " + parent);
				Output.Add("		}");
			}

			return this;
		}

		public override TreeSaver EndParents()
		{
			return this;
		}

		public override TreeSaver EndNode()
		{
			Output.Add("	}");
			return this;
		}

		public override TreeSaver StartParts()
		{
			// TODO : Buffer parts and stream to end of file as MM configs
			return this;
		}

		public override TreeSaver SaveParts(IEnumerable<PartViewModel> partsList)
		{
			foreach (var part in partsList)
			{
				_partsBuffer.Add("@PART[" + part.PartName + "]");
				_partsBuffer.Add("{");
				_partsBuffer.Add("  @TechRequired = " + part.TechRequired);
				_partsBuffer.Add("}");
			}
			return this;
		}

		public override TreeSaver EndParts()
		{
			return this;
		}

		public override TreeSaver EndTree()
		{
			Output.Add("}");
			Output.AddRange(_partsBuffer);
			return this;
		}
	}
}
