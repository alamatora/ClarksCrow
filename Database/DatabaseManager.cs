using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClarksCrow.Database {
    public partial class DatabaseManager : Form {
        public DatabaseManager() {
            InitializeComponent();

            tabControl.SelectedTab = tabControl.TabPages[0];

            treeView.MouseUp += new MouseEventHandler(treeView_MouseUp);
            treeView.AfterSelect += new TreeViewEventHandler(treeView_AfterSelect);
            treeView.AfterLabelEdit += new NodeLabelEditEventHandler(treeView_AfterLabelEdit);

            mf_nameTextBox.Leave += new EventHandler(textBox_Leave);
            mf_densityTextBox.Leave += new EventHandler(textBox_Leave);
            mi_nameTextBox.Leave += new EventHandler(textBox_Leave);
            mi_thicknessTextBox.Leave += new EventHandler(textBox_Leave);
            uev_nameTextBox.Leave += new EventHandler(textBox_Leave);
            uev_valueTextBox.Leave += new EventHandler(textBox_Leave);
            uev_unitsComboBox.Leave += new EventHandler(textBox_Leave);
            uev_gebTextBox.Leave += new EventHandler(textBox_Leave);
            uev_referenceTextBox.Leave += new EventHandler(textBox_Leave);

            mf_nameTextBox.KeyDown += new KeyEventHandler(textBox_KeyDown);
            mf_densityTextBox.KeyDown += new KeyEventHandler(textBox_KeyDown);
            mi_nameTextBox.KeyDown += new KeyEventHandler(textBox_KeyDown);
            mi_thicknessTextBox.KeyDown += new KeyEventHandler(textBox_KeyDown);
            uev_nameTextBox.KeyDown += new KeyEventHandler(textBox_KeyDown);
            uev_valueTextBox.KeyDown += new KeyEventHandler(textBox_KeyDown);
            uev_gebTextBox.KeyDown += new KeyEventHandler(textBox_KeyDown);
            uev_referenceTextBox.KeyDown += new KeyEventHandler(textBox_KeyDown);

            LoadDatabase();
        }

        #region TreeView Control

        //TODO: Potentially clean up or condense
        private void treeView_MouseUp(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                Point p = new Point(e.X, e.Y);
                treeView.SelectedNode = treeView.GetNodeAt(p);

                ToolStripItemCollection tsic = node_contextMenuStrip.Items;

                if (treeView.SelectedNode == null || treeView.SelectedNode.Parent == null) {    //Right-clicked on blank space or root node
                    ((ToolStripMenuItem)tsic["newMenuItem"]).DropDownItems["materialVolumeMenuItem"].Enabled = false;
                    ((ToolStripMenuItem)tsic["newMenuItem"]).DropDownItems["materialSurfaceMenuItem"].Enabled = false;
                    tsic["renameMenuItem"].Enabled = false;
                    tsic["deleteMenuItem"].Enabled = false;
                    node_contextMenuStrip.Show(treeView, p);
                }
                else if(treeView.SelectedNode.Parent == treeView.Nodes["Materials"] || treeView.SelectedNode.Parent.Parent == treeView.Nodes["Materials"]){ //Right-clicked on a material family or material instance
                    ((ToolStripMenuItem)tsic["newMenuItem"]).DropDownItems["materialVolumeMenuItem"].Enabled = true;
                    ((ToolStripMenuItem)tsic["newMenuItem"]).DropDownItems["materialSurfaceMenuItem"].Enabled = true;
                    tsic["renameMenuItem"].Enabled = true;
                    tsic["deleteMenuItem"].Enabled = true;
                    node_contextMenuStrip.Show(treeView, p);
                }
                else {  //Right-clicked on any other non-root node
                    ((ToolStripMenuItem)tsic["newMenuItem"]).DropDownItems["materialVolumeMenuItem"].Enabled = false;
                    ((ToolStripMenuItem)tsic["newMenuItem"]).DropDownItems["materialSurfaceMenuItem"].Enabled = false;
                    tsic["renameMenuItem"].Enabled = true;
                    tsic["deleteMenuItem"].Enabled = true;
                    node_contextMenuStrip.Show(treeView, p);
                }
            }
        }

        private void newMaterialFamilyMenuItem_Click(object sender, EventArgs e) {
            MaterialFamily newMaterialFamily = new MaterialFamily();
            Global.MaterialDatabase.Add(newMaterialFamily);
            InitializeNewNode(newMaterialFamily.Name, newMaterialFamily, treeView.Nodes["Materials"]);
        }

        private void newMaterialVolumeMenuItem_Click(object sender, EventArgs e) {
            TreeNode node = treeView.SelectedNode;
            if (node != null && node.Parent == treeView.Nodes["Materials"]) {
                MaterialVolume newMaterialVolume = new MaterialVolume();
                MaterialFamily materialFamily = node.Tag as MaterialFamily;
                newMaterialVolume.Family = materialFamily;
                materialFamily.MaterialInstances.Add(newMaterialVolume);
                InitializeNewNode(newMaterialVolume.Name, newMaterialVolume, node);
            }
        }

        private void newMaterialSurfaceMenuItem_Click(object sender, EventArgs e) {
            TreeNode node = treeView.SelectedNode;
            if (node != null && node.Parent == treeView.Nodes["Materials"]) {
                MaterialSurface newMaterialSurface = new MaterialSurface();
                MaterialFamily materialFamily = node.Tag as MaterialFamily;
                newMaterialSurface.Family = materialFamily;
                materialFamily.MaterialInstances.Add(newMaterialSurface);
                InitializeNewNode(newMaterialSurface.Name, newMaterialSurface, node);
            }
        }

        private void newUnitEmergyValueMenuItem_Click(object sender, EventArgs e) {
            UEV newUEV = new UEV();
            Global.UEVDatabase.Add(newUEV);
            InitializeNewNode(newUEV.Name, newUEV, treeView.Nodes["Unit Emergy Values"]);
        }

        private void renameMenuItem_Click(object sender, EventArgs e) {
            TreeNode node = treeView.SelectedNode;
            if(node != null && node.Parent != null) {
                EditNodeLabel(node);
            }
        }

        //TODO: Finish + Add warnings for deletion
        private void deleteMenuItem_Click(object sender, EventArgs e) {
            //TreeNode node = treeView.SelectedNode;
            //if(node != null && node.Parent != null) {
            //    if(node.Tag.GetType() == typeof(MaterialFamily)) {
            //        Global.MaterialDatabase.Remove(node.Tag as MaterialFamily);
            //    }
            //    else if(node.Tag is IMaterialInstance) {
                    
            //    }
            //}
        }

        private TreeNode InitializeNewNode(string name, IDatabaseItem tag, TreeNode parent) {
            TreeNode newNode = parent.Nodes.Add(name, name);
            newNode.Tag = tag;

            if (parent.IsExpanded != true) { newNode.Parent.Expand(); }

            treeView.SelectedNode = newNode;
            EditNodeLabel(newNode);

            return newNode;
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e) {
            RefreshPanel(e.Node);
        }

        //TODO: Simplify using TypeOf(tag) instead of checking nodes
        private void RefreshPanel(TreeNode node) {
            if (node != null && node.Parent != null) {
                if (node.Parent == treeView.Nodes["Materials"]) {
                    RefreshMaterialFamilyPanel(node.Tag as MaterialFamily);
                }
                else if (node.Parent.Parent == treeView.Nodes["Materials"]) {
                    RefreshMaterialInstancePanel(node.Tag as IMaterialInstance);
                }
                else {
                    TreeNode r_node = node;
                    while (r_node.Parent != null) {
                        r_node = r_node.Parent;
                    }
                    if (r_node == treeView.Nodes["Unit Emergy Values"]) {
                        RefreshUEVPanel(node.Tag as UEV);
                    }
                    else {
                        MessageBox.Show("Something has gone seriously wrong. Error with treeView_AfterSelect event.", "Error");
                    }
                }
            }
            else if (node != null && node.Parent == null) {
                tabControl.SelectedTab = tabControl.TabPages[0];
            }
        }

        private void EditNodeLabel(TreeNode node) {
            if (node != null && node.Parent != null) {
                treeView.LabelEdit = true;
                if (!node.IsEditing) {
                    node.BeginEdit();
                }
            }
            else {
                MessageBox.Show("No tree node selected or selected node is a root node.\n" + "Editing of root nodes is not allowed.", "Invalid selection");
            }
        }

        //TODO: Learn more about delegates and see if there's a way around this
        delegate void SortAndRefreshDelegate(TreeNode node);
        private void SortAndRefresh(TreeNode node) {
            treeView.Sort();
            treeView.SelectedNode = node;
            RefreshPanel(node);
        }

        private void treeView_AfterLabelEdit(object sender, NodeLabelEditEventArgs e) {
            if (e.Label != null) {
                if (e.Label.Length > 0) {
                    if (e.Label.IndexOfAny(new char[] { '@', '.', ',', '!' }) == -1) {
                        e.Node.EndEdit(false);
                        IDatabaseItem item = e.Node.Tag as IDatabaseItem;
                        item.Name = e.Label;
                        e.Node.Name = e.Label;
                        SortAndRefreshDelegate sortAndRefreshDelegate = SortAndRefresh;
                        treeView.BeginInvoke(sortAndRefreshDelegate, e.Node);
                        RefreshPanel(e.Node);
                    }
                    else {
                        e.CancelEdit = true;
                        MessageBox.Show("Invalid name.\n" + "Cannot use any of the following characters: '@','.', ',', '!'", "Name Edit");
                        e.Node.BeginEdit();
                    }
                }
                else {
                    e.CancelEdit = true;
                    MessageBox.Show("Invalid name.\nThe name cannot be left blank", "Name Edit");
                    e.Node.BeginEdit();
                }
            }
        }

        #endregion

        #region Property Panels

        private void RefreshMaterialFamilyPanel(MaterialFamily materialFamily) {
            tabControl.SelectedTab = tabControl.TabPages[1];
            mf_nameTextBox.Text = materialFamily.Name;
            mf_densityTextBox.Text = materialFamily.Density.ToString();
        }

        private void RefreshMaterialInstancePanel(IMaterialInstance materialInstance) {
            tabControl.SelectedTab = tabControl.TabPages[2];
            mi_nameTextBox.Text = materialInstance.Name;
            mi_densityTextBox.Text = materialInstance.Family.Density.ToString();

            MaterialSurface materialSurface = materialInstance as MaterialSurface;
            if (materialSurface != null) {
                mi_thicknessTextBox.ReadOnly = false;
                mi_thicknessTextBox.Text = materialSurface.Thickness.ToString();
            }
            else {
                mi_thicknessTextBox.ReadOnly = true;
                mi_thicknessTextBox.Text = "";
            }
        }

        private void RefreshUEVPanel(UEV UEV) {
            tabControl.SelectedTab = tabControl.TabPages[3];
            uev_nameTextBox.Text = UEV.Name;
            uev_valueTextBox.Text = UEV.Value.ToString("0.0##E+00");
            uev_unitsComboBox.SelectedIndex = (int)UEV.Unit;
            uev_gebTextBox.Text = UEV.GeobiosphereEmergyBaseline.ToString("0.0##E+00");
            uev_referenceTextBox.Text = UEV.Reference;
        }

        #endregion

        private void textBox_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                UpdateSelectedTagProperties();
            }
        }

        private void textBox_Leave(object sender, EventArgs e) {
            UpdateSelectedTagProperties();
        }

        //TODO: Potentially clean up + Add ratio textbox for material instances
        private void UpdateSelectedTagProperties() {
            TreeNode node = treeView.SelectedNode;
            if (node != null && node.Tag != null) {
                Type T = node.Tag.GetType();
                if (T == typeof(MaterialFamily)) {
                    MaterialFamily materialFamily = node.Tag as MaterialFamily;
                    materialFamily.Name = mf_nameTextBox.Text;
                    node.Text = mf_nameTextBox.Text;
                    node.Name = mf_nameTextBox.Text;
                    double density = materialFamily.Density;
                    ParseTextBoxNumber(mf_densityTextBox, ref density);
                    materialFamily.Density = density;
                }
                else if (node.Tag is IMaterialInstance) {
                    IMaterialInstance materialInstance = node.Tag as IMaterialInstance;
                    materialInstance.Name = mi_nameTextBox.Text;
                    node.Text = mi_nameTextBox.Text;
                    node.Name = mi_nameTextBox.Text;
                    if (T == typeof(MaterialSurface)) {
                        MaterialSurface materialSurface = materialInstance as MaterialSurface;
                        double thickness = materialSurface.Thickness;
                        ParseTextBoxNumber(mi_thicknessTextBox, ref thickness);
                        materialSurface.Thickness = thickness;
                    }
                }
                else if (T == typeof(UEV)) {
                    UEV UEV = node.Tag as UEV;
                    UEV.Name = uev_nameTextBox.Text;
                    node.Text = uev_nameTextBox.Text;
                    node.Name = uev_nameTextBox.Text;
                    double value = UEV.Value;
                    ParseTextBoxNumber(uev_valueTextBox, ref value);
                    UEV.Value = value;
                    UEV.Unit = (Units)Enum.Parse(typeof(Units), uev_unitsComboBox.Text);    //TODO: Check and potentially make cleaner
                    double geb = UEV.GeobiosphereEmergyBaseline;
                    ParseTextBoxNumber(uev_gebTextBox, ref geb);
                    UEV.GeobiosphereEmergyBaseline = geb;
                    UEV.Reference = uev_referenceTextBox.Text;
                }
                treeView.Sort();
            }
        }

        //TODO: Fix rounding issue / scientific notation display. TextBox might have a format property?
        private void ParseTextBoxNumber(TextBox textBox, ref double property) {
            double parsedDouble;
            if(double.TryParse(textBox.Text, out parsedDouble)) {
                property = parsedDouble;
            }
            else {
                MessageBox.Show("Please input a valid number.", "Error");
                textBox.Text = property.ToString();
            }
        }
    

        private void LoadDatabase() {
            Global.MaterialDatabase.Sort(new DatabaseNameComparer());
            Global.UEVDatabase.Sort(new DatabaseNameComparer());
            foreach(MaterialFamily materialFamily in Global.MaterialDatabase) {
                TreeNode node = InitializeNewNode(materialFamily.Name, materialFamily, treeView.Nodes["Materials"]);
                materialFamily.MaterialInstances.Sort(new DatabaseNameComparer());
                foreach (IMaterialInstance materialInstance in materialFamily.MaterialInstances) {
                    InitializeNewNode(materialInstance.Name, materialInstance, node);
                }
            }
            //TODO: Implement nested UEVs
            foreach(UEV UEV in Global.UEVDatabase) {
                InitializeNewNode(UEV.Name, UEV, treeView.Nodes["Unit Emergy Values"]);
            }
        }
    }
}
