using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows;
using ksp_techtree_edit.Models;
using ksp_techtree_edit.Properties;

namespace ksp_techtree_edit.ViewModels
{
	public class TechTreeViewModel : NotificationViewModel
	{
		#region Members

		#region Private

		private WorkspaceViewModel _workspaceViewModel;
		private PartCollectionViewModel _partCollectionViewModel;
		private Point _mousePosition;

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

		public PartCollectionViewModel PartCollectionViewModel
		{
			get { return _partCollectionViewModel; }
			set
			{
				if (_partCollectionViewModel == value) return;
				_partCollectionViewModel = value;
				OnPropertyChanged();
			}
		}

		public Point MousePosition
		{
			get { return _mousePosition; }
			set
			{
				if (_mousePosition == value) return;
				_mousePosition = value;
				OnPropertyChanged();
			}
		}

		public string[] StockNodes { get; set; }

		#endregion Public

		#endregion Members

		#region Constructors

		public TechTreeViewModel()
		{
			Connections = new ObservableCollection<ConnectionViewModel>();
			TechTree = new ObservableCollection<TechNodeViewModel>();
			StockNodes =
				Resources.stocknodes.
				          Split(
				                new[] { ',' },
				                StringSplitOptions.RemoveEmptyEntries);
		}

		#endregion Constructors

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
			WorkspaceViewModel.SelectedNode = null;
			TechTree.Remove(node);
			UnlinkParent(node);
			var parts = new PartViewModel[node.Parts.Count];
			node.Parts.CopyTo(parts, 0);
			foreach (var part in parts)
			{
				PartCollectionViewModel.RemovePartFromNode(part, node);
			}
			LinkNodes();
		}

		public TechNodeViewModel AddNode(Point pos)
		{
			var node = new TechNode(GenerateNodeName()) { Pos = pos };
			var nodeViewModel = new TechNodeViewModel { TechNode = node };
			TechTree.Add(nodeViewModel);
			return nodeViewModel;
		}

		public string GenerateNodeName()
		{
			foreach (var stockNodeName in StockNodes)
			{
				if (!ContainsNodeName(stockNodeName)) return stockNodeName;
			}

			const string namePrefix = "newnode_";
			var randGen = new Random();
			var limit = 9999;
			var name = namePrefix + randGen.Next(100, limit);

			for (var i = 0; i < limit; i++)
			{
				if (!ContainsNodeName(name))
				{
					return name;
				}

				if (i == limit - 1)
				{
					limit = (limit * 10) + 9;
				}

				name = namePrefix + randGen.Next(100, limit);
			}

			return name;
		}

		public bool ContainsNodeName(string nodeName)
		{
			foreach (var nodeViewModel in TechTree)
			{
				if (nodeViewModel.NodeName == nodeName)
				{
					return true;
				}
			}
			return false;
		}

		//TODO: Remove this terrible terrible method and replace with proper
		//MVVM model-viewmodel dependencies.
		public void UnlinkParent(TechNodeViewModel parentToRemove)
		{
			foreach (var node in TechTree)
			{
				if (node.Parents.Contains(parentToRemove))
				{
					node.RemoveParent(parentToRemove);
				}
			}
		}

		public void Save(TreeSaver saver, string path)
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
			saver.Save(path);
		}

		#endregion Methods
	}

	public abstract class TreeSaver
	{
		private readonly List<string> _output = new List<string>();

		protected int IndentationLevel = 0;

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
			File.WriteAllLines(path, _output);
		}

		protected void AddLine(int count = 1)
		{
			for (var i = 0; i < count; i++)
			{
				_output.Add(Environment.NewLine);
			}
		}

		protected void AddLine(string line)
		{
			_output.Add(Tabs + line);
		}

		protected void AddLineRange(ICollection<string> lines)
		{
			foreach (var line in lines)
			{
				AddLine(line);
			}
		}

		private string Tabs
		{
			get { return new String('\t', IndentationLevel); }
		}
	}

	public class TechManagerSaver : TreeSaver
	{
		public override TreeSaver StartTree(TechTreeViewModel techTree = null)
		{
			AddLine("TECHNOLOGY_TREE_DEFINITION");
			AddLine("{");
			IndentationLevel++;
			AddLine("id = TEDGeneratedTree");
			AddLine("label = TED Generated Tree");
			return this;
		}

		public override TreeSaver StartNode()
		{
			AddLine("NODE");
			AddLine("{");
			IndentationLevel++;
			return this;
		}

		public override TreeSaver SaveAttribute(KeyValuePair<string, string> nameAttributePair)
		{
			AddLine(nameAttributePair.Key + " = " + nameAttributePair.Value);
			return this;
		}

		public override TreeSaver SavePosition(double x, double y, double z)
		{
			var pos = x + "," + y + "," + z;
			AddLine("pos = " + pos);
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

			AddLine("parents = " + parentsOutput);
			return this;
		}

		public override TreeSaver EndParents()
		{
			return this;
		}

		public override TreeSaver EndNode()
		{
			IndentationLevel--;
			AddLine("}");
			return this;
		}

		public override TreeSaver StartParts()
		{
			AddLine("PARTS");
			AddLine("{");
			IndentationLevel++;
			return this;
		}

		public override TreeSaver SaveParts(IEnumerable<PartViewModel> partsList)
		{
			foreach (var part in partsList)
			{
				AddLine("name = " + part.PartName);
			}
			return this;
		}

		public override TreeSaver EndParts()
		{
			IndentationLevel--;
			AddLine("}");
			return this;
		}

		public override TreeSaver EndTree()
		{
			IndentationLevel--;
			AddLine("}");
			return this;
		}
	}

	public class ATCSaver : TreeSaver
	{
		private readonly List<string> _partsBuffer = new List<string>();

		public override TreeSaver StartTree(TechTreeViewModel techTree = null)
		{
			AddLine("TECH_TREE");
			AddLine("{");
			IndentationLevel++;
			AddLine("name = test");
			return this;
		}

		public override TreeSaver StartNode()
		{
			AddLine("TECH_NODE");
			AddLine("{");
			IndentationLevel++;
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
			AddLine(key + " = " + nameAttributePair.Value);
			return this;
		}

		public override TreeSaver SavePosition(double x, double y, double z)
		{
			AddLine("posX = " + x);
			AddLine("posY = " + y);
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
				AddLine("PARENT_NODE");
				AddLine("{");
				IndentationLevel++;
				AddLine("name = " + parent);
				IndentationLevel--;
				AddLine("}");
			}

			return this;
		}

		public override TreeSaver EndParents()
		{
			return this;
		}

		public override TreeSaver EndNode()
		{
			IndentationLevel--;
			AddLine("}");
			return this;
		}

		public override TreeSaver StartParts()
		{
			return this;
		}

		public override TreeSaver SaveParts(IEnumerable<PartViewModel> partsList)
		{
			foreach (var part in partsList)
			{
				_partsBuffer.Add("@PART[" + part.PartName + "]");
				_partsBuffer.Add("{");
				IndentationLevel++;
				_partsBuffer.Add("@TechRequired = " + part.TechRequired);
				IndentationLevel--;
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
			IndentationLevel--;
			AddLine("}");
			AddLineRange(_partsBuffer);
			return this;
		}
	}
}
