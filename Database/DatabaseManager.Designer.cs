namespace ClarksCrow.Database {
    partial class DatabaseManager {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Materials");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Unit Emergy Values");
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.blankTabPage = new System.Windows.Forms.TabPage();
            this.materialFamilyTab = new System.Windows.Forms.TabPage();
            this.mf_propertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.mf_densityUnits = new System.Windows.Forms.Label();
            this.mf_densityTextBox = new System.Windows.Forms.TextBox();
            this.mf_densityLabel = new System.Windows.Forms.Label();
            this.mf_nameTextBox = new System.Windows.Forms.TextBox();
            this.mf_nameLabel = new System.Windows.Forms.Label();
            this.materialInstanceTab = new System.Windows.Forms.TabPage();
            this.mi_propertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.mi_densityUnits = new System.Windows.Forms.Label();
            this.mi_thicknessUnits = new System.Windows.Forms.Label();
            this.mi_densityTextBox = new System.Windows.Forms.TextBox();
            this.mi_densityLabel = new System.Windows.Forms.Label();
            this.mi_thicknessTextBox = new System.Windows.Forms.TextBox();
            this.mi_thicknessLabel = new System.Windows.Forms.Label();
            this.mi_nameTextBox = new System.Windows.Forms.TextBox();
            this.mi_nameLabel = new System.Windows.Forms.Label();
            this.UEVTab = new System.Windows.Forms.TabPage();
            this.uev_descriptionLabel = new System.Windows.Forms.Label();
            this.uev_propertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.uev_referenceTextBox = new System.Windows.Forms.TextBox();
            this.uev_referenceLabel = new System.Windows.Forms.Label();
            this.uev_unitsComboBox = new System.Windows.Forms.ComboBox();
            this.uev_gebUnits = new System.Windows.Forms.Label();
            this.uev_valueTextBox = new System.Windows.Forms.TextBox();
            this.uev_valueLabel = new System.Windows.Forms.Label();
            this.uev_gebTextBox = new System.Windows.Forms.TextBox();
            this.uev_gebLabel = new System.Windows.Forms.Label();
            this.uev_nameTextBox = new System.Windows.Forms.TextBox();
            this.uev_nameLabel = new System.Windows.Forms.Label();
            this.node_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialFamilyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialVolumeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialSurfaceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitEmergyValueMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.materialFamilyTab.SuspendLayout();
            this.mf_propertiesGroupBox.SuspendLayout();
            this.materialInstanceTab.SuspendLayout();
            this.mi_propertiesGroupBox.SuspendLayout();
            this.UEVTab.SuspendLayout();
            this.uev_propertiesGroupBox.SuspendLayout();
            this.node_contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.treeView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tabControl);
            this.splitContainer.Size = new System.Drawing.Size(795, 465);
            this.splitContainer.SplitterDistance = 265;
            this.splitContainer.TabIndex = 0;
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            treeNode3.Name = "Materials";
            treeNode3.Text = "Materials";
            treeNode4.Name = "Unit Emergy Values";
            treeNode4.Text = "Unit Emergy Values";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            this.treeView.Size = new System.Drawing.Size(265, 465);
            this.treeView.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl.Controls.Add(this.blankTabPage);
            this.tabControl.Controls.Add(this.materialFamilyTab);
            this.tabControl.Controls.Add(this.materialInstanceTab);
            this.tabControl.Controls.Add(this.UEVTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(0, 0);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(526, 465);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 2;
            // 
            // blankTabPage
            // 
            this.blankTabPage.Location = new System.Drawing.Point(4, 5);
            this.blankTabPage.Name = "blankTabPage";
            this.blankTabPage.Size = new System.Drawing.Size(518, 456);
            this.blankTabPage.TabIndex = 3;
            this.blankTabPage.Text = "Blank";
            this.blankTabPage.UseVisualStyleBackColor = true;
            // 
            // materialFamilyTab
            // 
            this.materialFamilyTab.Controls.Add(this.mf_propertiesGroupBox);
            this.materialFamilyTab.Location = new System.Drawing.Point(4, 5);
            this.materialFamilyTab.Name = "materialFamilyTab";
            this.materialFamilyTab.Padding = new System.Windows.Forms.Padding(3);
            this.materialFamilyTab.Size = new System.Drawing.Size(518, 456);
            this.materialFamilyTab.TabIndex = 0;
            this.materialFamilyTab.Text = "Material Family Tab";
            this.materialFamilyTab.UseVisualStyleBackColor = true;
            // 
            // mf_propertiesGroupBox
            // 
            this.mf_propertiesGroupBox.Controls.Add(this.mf_densityUnits);
            this.mf_propertiesGroupBox.Controls.Add(this.mf_densityTextBox);
            this.mf_propertiesGroupBox.Controls.Add(this.mf_densityLabel);
            this.mf_propertiesGroupBox.Controls.Add(this.mf_nameTextBox);
            this.mf_propertiesGroupBox.Controls.Add(this.mf_nameLabel);
            this.mf_propertiesGroupBox.Location = new System.Drawing.Point(21, 22);
            this.mf_propertiesGroupBox.Name = "mf_propertiesGroupBox";
            this.mf_propertiesGroupBox.Size = new System.Drawing.Size(469, 103);
            this.mf_propertiesGroupBox.TabIndex = 1;
            this.mf_propertiesGroupBox.TabStop = false;
            this.mf_propertiesGroupBox.Text = "Properties";
            // 
            // mf_densityUnits
            // 
            this.mf_densityUnits.AutoSize = true;
            this.mf_densityUnits.Location = new System.Drawing.Point(162, 61);
            this.mf_densityUnits.Name = "mf_densityUnits";
            this.mf_densityUnits.Size = new System.Drawing.Size(44, 13);
            this.mf_densityUnits.TabIndex = 4;
            this.mf_densityUnits.Text = "kg/m^3";
            // 
            // mf_densityTextBox
            // 
            this.mf_densityTextBox.Location = new System.Drawing.Point(76, 58);
            this.mf_densityTextBox.Name = "mf_densityTextBox";
            this.mf_densityTextBox.Size = new System.Drawing.Size(79, 20);
            this.mf_densityTextBox.TabIndex = 3;
            // 
            // mf_densityLabel
            // 
            this.mf_densityLabel.AutoSize = true;
            this.mf_densityLabel.Location = new System.Drawing.Point(28, 61);
            this.mf_densityLabel.Name = "mf_densityLabel";
            this.mf_densityLabel.Size = new System.Drawing.Size(42, 13);
            this.mf_densityLabel.TabIndex = 2;
            this.mf_densityLabel.Text = "Density";
            // 
            // mf_nameTextBox
            // 
            this.mf_nameTextBox.Location = new System.Drawing.Point(76, 28);
            this.mf_nameTextBox.Name = "mf_nameTextBox";
            this.mf_nameTextBox.Size = new System.Drawing.Size(276, 20);
            this.mf_nameTextBox.TabIndex = 1;
            // 
            // mf_nameLabel
            // 
            this.mf_nameLabel.AutoSize = true;
            this.mf_nameLabel.Location = new System.Drawing.Point(28, 31);
            this.mf_nameLabel.Name = "mf_nameLabel";
            this.mf_nameLabel.Size = new System.Drawing.Size(35, 13);
            this.mf_nameLabel.TabIndex = 0;
            this.mf_nameLabel.Text = "Name";
            // 
            // materialInstanceTab
            // 
            this.materialInstanceTab.Controls.Add(this.mi_propertiesGroupBox);
            this.materialInstanceTab.Location = new System.Drawing.Point(4, 5);
            this.materialInstanceTab.Name = "materialInstanceTab";
            this.materialInstanceTab.Padding = new System.Windows.Forms.Padding(3);
            this.materialInstanceTab.Size = new System.Drawing.Size(518, 456);
            this.materialInstanceTab.TabIndex = 1;
            this.materialInstanceTab.Text = "Material Instance Tab";
            this.materialInstanceTab.UseVisualStyleBackColor = true;
            // 
            // mi_propertiesGroupBox
            // 
            this.mi_propertiesGroupBox.Controls.Add(this.mi_densityUnits);
            this.mi_propertiesGroupBox.Controls.Add(this.mi_thicknessUnits);
            this.mi_propertiesGroupBox.Controls.Add(this.mi_densityTextBox);
            this.mi_propertiesGroupBox.Controls.Add(this.mi_densityLabel);
            this.mi_propertiesGroupBox.Controls.Add(this.mi_thicknessTextBox);
            this.mi_propertiesGroupBox.Controls.Add(this.mi_thicknessLabel);
            this.mi_propertiesGroupBox.Controls.Add(this.mi_nameTextBox);
            this.mi_propertiesGroupBox.Controls.Add(this.mi_nameLabel);
            this.mi_propertiesGroupBox.Location = new System.Drawing.Point(25, 23);
            this.mi_propertiesGroupBox.Name = "mi_propertiesGroupBox";
            this.mi_propertiesGroupBox.Size = new System.Drawing.Size(469, 118);
            this.mi_propertiesGroupBox.TabIndex = 5;
            this.mi_propertiesGroupBox.TabStop = false;
            this.mi_propertiesGroupBox.Text = "Properties";
            // 
            // mi_densityUnits
            // 
            this.mi_densityUnits.AutoSize = true;
            this.mi_densityUnits.Location = new System.Drawing.Point(175, 57);
            this.mi_densityUnits.Name = "mi_densityUnits";
            this.mi_densityUnits.Size = new System.Drawing.Size(44, 13);
            this.mi_densityUnits.TabIndex = 4;
            this.mi_densityUnits.Text = "kg/m^3";
            // 
            // mi_thicknessUnits
            // 
            this.mi_thicknessUnits.AutoSize = true;
            this.mi_thicknessUnits.Location = new System.Drawing.Point(175, 83);
            this.mi_thicknessUnits.Name = "mi_thicknessUnits";
            this.mi_thicknessUnits.Size = new System.Drawing.Size(15, 13);
            this.mi_thicknessUnits.TabIndex = 4;
            this.mi_thicknessUnits.Text = "m";
            // 
            // mi_densityTextBox
            // 
            this.mi_densityTextBox.Location = new System.Drawing.Point(90, 54);
            this.mi_densityTextBox.Name = "mi_densityTextBox";
            this.mi_densityTextBox.ReadOnly = true;
            this.mi_densityTextBox.Size = new System.Drawing.Size(79, 20);
            this.mi_densityTextBox.TabIndex = 3;
            // 
            // mi_densityLabel
            // 
            this.mi_densityLabel.AutoSize = true;
            this.mi_densityLabel.Location = new System.Drawing.Point(28, 57);
            this.mi_densityLabel.Name = "mi_densityLabel";
            this.mi_densityLabel.Size = new System.Drawing.Size(42, 13);
            this.mi_densityLabel.TabIndex = 2;
            this.mi_densityLabel.Text = "Density";
            // 
            // mi_thicknessTextBox
            // 
            this.mi_thicknessTextBox.Location = new System.Drawing.Point(90, 80);
            this.mi_thicknessTextBox.Name = "mi_thicknessTextBox";
            this.mi_thicknessTextBox.Size = new System.Drawing.Size(79, 20);
            this.mi_thicknessTextBox.TabIndex = 3;
            // 
            // mi_thicknessLabel
            // 
            this.mi_thicknessLabel.AutoSize = true;
            this.mi_thicknessLabel.Location = new System.Drawing.Point(28, 83);
            this.mi_thicknessLabel.Name = "mi_thicknessLabel";
            this.mi_thicknessLabel.Size = new System.Drawing.Size(56, 13);
            this.mi_thicknessLabel.TabIndex = 2;
            this.mi_thicknessLabel.Text = "Thickness";
            // 
            // mi_nameTextBox
            // 
            this.mi_nameTextBox.Location = new System.Drawing.Point(90, 28);
            this.mi_nameTextBox.Name = "mi_nameTextBox";
            this.mi_nameTextBox.Size = new System.Drawing.Size(276, 20);
            this.mi_nameTextBox.TabIndex = 1;
            // 
            // mi_nameLabel
            // 
            this.mi_nameLabel.AutoSize = true;
            this.mi_nameLabel.Location = new System.Drawing.Point(28, 31);
            this.mi_nameLabel.Name = "mi_nameLabel";
            this.mi_nameLabel.Size = new System.Drawing.Size(35, 13);
            this.mi_nameLabel.TabIndex = 0;
            this.mi_nameLabel.Text = "Name";
            // 
            // UEVTab
            // 
            this.UEVTab.Controls.Add(this.uev_descriptionLabel);
            this.UEVTab.Controls.Add(this.uev_propertiesGroupBox);
            this.UEVTab.Location = new System.Drawing.Point(4, 5);
            this.UEVTab.Name = "UEVTab";
            this.UEVTab.Size = new System.Drawing.Size(518, 456);
            this.UEVTab.TabIndex = 2;
            this.UEVTab.Text = "UEB Tab";
            this.UEVTab.UseVisualStyleBackColor = true;
            // 
            // uev_descriptionLabel
            // 
            this.uev_descriptionLabel.AutoSize = true;
            this.uev_descriptionLabel.Location = new System.Drawing.Point(23, 192);
            this.uev_descriptionLabel.Name = "uev_descriptionLabel";
            this.uev_descriptionLabel.Size = new System.Drawing.Size(165, 39);
            this.uev_descriptionLabel.TabIndex = 7;
            this.uev_descriptionLabel.Text = "*Geobiosphere Emergy Baseline\r\n\r\nMore description text about UEVs";
            // 
            // uev_propertiesGroupBox
            // 
            this.uev_propertiesGroupBox.Controls.Add(this.uev_referenceTextBox);
            this.uev_propertiesGroupBox.Controls.Add(this.uev_referenceLabel);
            this.uev_propertiesGroupBox.Controls.Add(this.uev_unitsComboBox);
            this.uev_propertiesGroupBox.Controls.Add(this.uev_gebUnits);
            this.uev_propertiesGroupBox.Controls.Add(this.uev_valueTextBox);
            this.uev_propertiesGroupBox.Controls.Add(this.uev_valueLabel);
            this.uev_propertiesGroupBox.Controls.Add(this.uev_gebTextBox);
            this.uev_propertiesGroupBox.Controls.Add(this.uev_gebLabel);
            this.uev_propertiesGroupBox.Controls.Add(this.uev_nameTextBox);
            this.uev_propertiesGroupBox.Controls.Add(this.uev_nameLabel);
            this.uev_propertiesGroupBox.Location = new System.Drawing.Point(26, 23);
            this.uev_propertiesGroupBox.Name = "uev_propertiesGroupBox";
            this.uev_propertiesGroupBox.Size = new System.Drawing.Size(469, 149);
            this.uev_propertiesGroupBox.TabIndex = 6;
            this.uev_propertiesGroupBox.TabStop = false;
            this.uev_propertiesGroupBox.Text = "Properties";
            // 
            // uev_referenceTextBox
            // 
            this.uev_referenceTextBox.Location = new System.Drawing.Point(90, 106);
            this.uev_referenceTextBox.Name = "uev_referenceTextBox";
            this.uev_referenceTextBox.Size = new System.Drawing.Size(276, 20);
            this.uev_referenceTextBox.TabIndex = 7;
            // 
            // uev_referenceLabel
            // 
            this.uev_referenceLabel.AutoSize = true;
            this.uev_referenceLabel.Location = new System.Drawing.Point(28, 109);
            this.uev_referenceLabel.Name = "uev_referenceLabel";
            this.uev_referenceLabel.Size = new System.Drawing.Size(57, 13);
            this.uev_referenceLabel.TabIndex = 6;
            this.uev_referenceLabel.Text = "Reference";
            // 
            // uev_unitsComboBox
            // 
            this.uev_unitsComboBox.FormattingEnabled = true;
            this.uev_unitsComboBox.Items.AddRange(new object[] {
            "J",
            "kg"});
            this.uev_unitsComboBox.Location = new System.Drawing.Point(227, 53);
            this.uev_unitsComboBox.Name = "uev_unitsComboBox";
            this.uev_unitsComboBox.Size = new System.Drawing.Size(69, 21);
            this.uev_unitsComboBox.TabIndex = 5;
            // 
            // uev_gebUnits
            // 
            this.uev_gebUnits.AutoSize = true;
            this.uev_gebUnits.Location = new System.Drawing.Point(227, 83);
            this.uev_gebUnits.Name = "uev_gebUnits";
            this.uev_gebUnits.Size = new System.Drawing.Size(36, 13);
            this.uev_gebUnits.TabIndex = 4;
            this.uev_gebUnits.Text = "seJ/yr";
            // 
            // uev_valueTextBox
            // 
            this.uev_valueTextBox.Location = new System.Drawing.Point(90, 54);
            this.uev_valueTextBox.Name = "uev_valueTextBox";
            this.uev_valueTextBox.Size = new System.Drawing.Size(131, 20);
            this.uev_valueTextBox.TabIndex = 3;
            // 
            // uev_valueLabel
            // 
            this.uev_valueLabel.AutoSize = true;
            this.uev_valueLabel.Location = new System.Drawing.Point(28, 57);
            this.uev_valueLabel.Name = "uev_valueLabel";
            this.uev_valueLabel.Size = new System.Drawing.Size(34, 13);
            this.uev_valueLabel.TabIndex = 2;
            this.uev_valueLabel.Text = "Value";
            // 
            // uev_gebTextBox
            // 
            this.uev_gebTextBox.Location = new System.Drawing.Point(90, 80);
            this.uev_gebTextBox.Name = "uev_gebTextBox";
            this.uev_gebTextBox.Size = new System.Drawing.Size(131, 20);
            this.uev_gebTextBox.TabIndex = 3;
            // 
            // uev_gebLabel
            // 
            this.uev_gebLabel.AutoSize = true;
            this.uev_gebLabel.Location = new System.Drawing.Point(28, 83);
            this.uev_gebLabel.Name = "uev_gebLabel";
            this.uev_gebLabel.Size = new System.Drawing.Size(33, 13);
            this.uev_gebLabel.TabIndex = 2;
            this.uev_gebLabel.Text = "GEB*";
            // 
            // uev_nameTextBox
            // 
            this.uev_nameTextBox.Location = new System.Drawing.Point(90, 28);
            this.uev_nameTextBox.Name = "uev_nameTextBox";
            this.uev_nameTextBox.Size = new System.Drawing.Size(276, 20);
            this.uev_nameTextBox.TabIndex = 1;
            // 
            // uev_nameLabel
            // 
            this.uev_nameLabel.AutoSize = true;
            this.uev_nameLabel.Location = new System.Drawing.Point(28, 31);
            this.uev_nameLabel.Name = "uev_nameLabel";
            this.uev_nameLabel.Size = new System.Drawing.Size(35, 13);
            this.uev_nameLabel.TabIndex = 0;
            this.uev_nameLabel.Text = "Name";
            // 
            // node_contextMenuStrip
            // 
            this.node_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            this.renameMenuItem,
            this.deleteMenuItem});
            this.node_contextMenuStrip.Name = "contextMenuStrip1";
            this.node_contextMenuStrip.Size = new System.Drawing.Size(118, 70);
            // 
            // newMenuItem
            // 
            this.newMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materialFamilyMenuItem,
            this.materialVolumeMenuItem,
            this.materialSurfaceMenuItem,
            this.unitEmergyValueMenuItem});
            this.newMenuItem.Name = "newMenuItem";
            this.newMenuItem.Size = new System.Drawing.Size(117, 22);
            this.newMenuItem.Text = "New...";
            // 
            // materialFamilyMenuItem
            // 
            this.materialFamilyMenuItem.Name = "materialFamilyMenuItem";
            this.materialFamilyMenuItem.Size = new System.Drawing.Size(170, 22);
            this.materialFamilyMenuItem.Text = "Material Family";
            this.materialFamilyMenuItem.Click += new System.EventHandler(this.newMaterialFamilyMenuItem_Click);
            // 
            // materialVolumeMenuItem
            // 
            this.materialVolumeMenuItem.Name = "materialVolumeMenuItem";
            this.materialVolumeMenuItem.Size = new System.Drawing.Size(170, 22);
            this.materialVolumeMenuItem.Text = "Material Volume";
            this.materialVolumeMenuItem.Click += new System.EventHandler(this.newMaterialVolumeMenuItem_Click);
            // 
            // materialSurfaceMenuItem
            // 
            this.materialSurfaceMenuItem.Name = "materialSurfaceMenuItem";
            this.materialSurfaceMenuItem.Size = new System.Drawing.Size(170, 22);
            this.materialSurfaceMenuItem.Text = "Material Surface";
            this.materialSurfaceMenuItem.Click += new System.EventHandler(this.newMaterialSurfaceMenuItem_Click);
            // 
            // unitEmergyValueMenuItem
            // 
            this.unitEmergyValueMenuItem.Name = "unitEmergyValueMenuItem";
            this.unitEmergyValueMenuItem.Size = new System.Drawing.Size(170, 22);
            this.unitEmergyValueMenuItem.Text = "Unit Emergy Value";
            this.unitEmergyValueMenuItem.Click += new System.EventHandler(this.newUnitEmergyValueMenuItem_Click);
            // 
            // renameMenuItem
            // 
            this.renameMenuItem.Name = "renameMenuItem";
            this.renameMenuItem.Size = new System.Drawing.Size(152, 22);
            this.renameMenuItem.Text = "Rename";
            this.renameMenuItem.Click += new System.EventHandler(this.renameMenuItem_Click);
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteMenuItem.Text = "Delete";
            this.deleteMenuItem.Click += new System.EventHandler(this.deleteMenuItem_Click);
            // 
            // DatabaseManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 465);
            this.Controls.Add(this.splitContainer);
            this.Name = "DatabaseManager";
            this.Text = "Database Manager";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.materialFamilyTab.ResumeLayout(false);
            this.mf_propertiesGroupBox.ResumeLayout(false);
            this.mf_propertiesGroupBox.PerformLayout();
            this.materialInstanceTab.ResumeLayout(false);
            this.mi_propertiesGroupBox.ResumeLayout(false);
            this.mi_propertiesGroupBox.PerformLayout();
            this.UEVTab.ResumeLayout(false);
            this.UEVTab.PerformLayout();
            this.uev_propertiesGroupBox.ResumeLayout(false);
            this.uev_propertiesGroupBox.PerformLayout();
            this.node_contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage materialFamilyTab;
        private System.Windows.Forms.TabPage materialInstanceTab;
        private System.Windows.Forms.Label mi_densityUnits;
        private System.Windows.Forms.TextBox mi_densityTextBox;
        private System.Windows.Forms.Label mi_densityLabel;
        private System.Windows.Forms.TabPage UEVTab;
        private System.Windows.Forms.GroupBox mi_propertiesGroupBox;
        private System.Windows.Forms.Label mi_thicknessUnits;
        private System.Windows.Forms.TextBox mi_thicknessTextBox;
        private System.Windows.Forms.Label mi_thicknessLabel;
        private System.Windows.Forms.TextBox mi_nameTextBox;
        private System.Windows.Forms.Label mi_nameLabel;
        private System.Windows.Forms.GroupBox mf_propertiesGroupBox;
        private System.Windows.Forms.Label mf_densityUnits;
        private System.Windows.Forms.TextBox mf_densityTextBox;
        private System.Windows.Forms.Label mf_densityLabel;
        private System.Windows.Forms.TextBox mf_nameTextBox;
        private System.Windows.Forms.Label mf_nameLabel;
        private System.Windows.Forms.Label uev_descriptionLabel;
        private System.Windows.Forms.GroupBox uev_propertiesGroupBox;
        private System.Windows.Forms.TextBox uev_referenceTextBox;
        private System.Windows.Forms.Label uev_referenceLabel;
        private System.Windows.Forms.ComboBox uev_unitsComboBox;
        private System.Windows.Forms.Label uev_gebUnits;
        private System.Windows.Forms.TextBox uev_valueTextBox;
        private System.Windows.Forms.Label uev_valueLabel;
        private System.Windows.Forms.TextBox uev_gebTextBox;
        private System.Windows.Forms.Label uev_gebLabel;
        private System.Windows.Forms.TextBox uev_nameTextBox;
        private System.Windows.Forms.Label uev_nameLabel;
        private System.Windows.Forms.TabPage blankTabPage;
        private System.Windows.Forms.ContextMenuStrip node_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem newMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialFamilyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialVolumeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialSurfaceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitEmergyValueMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
    }
}