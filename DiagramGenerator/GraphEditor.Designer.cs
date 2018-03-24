namespace DiagramGenerator
{
    partial class GraphEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphEditor));
            this.diagramDBDataSet = new DiagramGenerator.DiagramDBDataSet();
            this.graphBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.graphTableAdapter = new DiagramGenerator.DiagramDBDataSetTableAdapters.GraphTableAdapter();
            this.tableAdapterManager = new DiagramGenerator.DiagramDBDataSetTableAdapters.TableAdapterManager();
            this.graphBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.graphBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.graphDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intervalTableAdapter = new DiagramGenerator.DiagramDBDataSetTableAdapters.IntervalTableAdapter();
            this.intervalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.diagramDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphBindingNavigator)).BeginInit();
            this.graphBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // diagramDBDataSet
            // 
            this.diagramDBDataSet.DataSetName = "DiagramDBDataSet";
            this.diagramDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // graphBindingSource
            // 
            this.graphBindingSource.DataMember = "Graph";
            this.graphBindingSource.DataSource = this.diagramDBDataSet;
            // 
            // graphTableAdapter
            // 
            this.graphTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GraphTableAdapter = this.graphTableAdapter;
            this.tableAdapterManager.IntervalTableAdapter = this.intervalTableAdapter;
            this.tableAdapterManager.UpdateOrder = DiagramGenerator.DiagramDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // graphBindingNavigator
            // 
            this.graphBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.graphBindingNavigator.BindingSource = this.graphBindingSource;
            this.graphBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.graphBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.graphBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.graphBindingNavigatorSaveItem});
            this.graphBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.graphBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.graphBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.graphBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.graphBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.graphBindingNavigator.Name = "graphBindingNavigator";
            this.graphBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.graphBindingNavigator.Size = new System.Drawing.Size(384, 25);
            this.graphBindingNavigator.TabIndex = 0;
            this.graphBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // graphBindingNavigatorSaveItem
            // 
            this.graphBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.graphBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("graphBindingNavigatorSaveItem.Image")));
            this.graphBindingNavigatorSaveItem.Name = "graphBindingNavigatorSaveItem";
            this.graphBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.graphBindingNavigatorSaveItem.Text = "Save Data";
            this.graphBindingNavigatorSaveItem.Click += new System.EventHandler(this.graphBindingNavigatorSaveItem_Click);
            // 
            // graphDataGridView
            // 
            this.graphDataGridView.AutoGenerateColumns = false;
            this.graphDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.graphDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.graphDataGridView.DataSource = this.graphBindingSource;
            this.graphDataGridView.Location = new System.Drawing.Point(12, 28);
            this.graphDataGridView.Name = "graphDataGridView";
            this.graphDataGridView.Size = new System.Drawing.Size(360, 327);
            this.graphDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "graphID";
            this.dataGridViewTextBoxColumn1.HeaderText = "graphID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "xPoint";
            this.dataGridViewTextBoxColumn2.HeaderText = "xPoint";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "yPoint";
            this.dataGridViewTextBoxColumn3.HeaderText = "yPoint";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // intervalTableAdapter
            // 
            this.intervalTableAdapter.ClearBeforeFill = true;
            // 
            // intervalBindingSource
            // 
            this.intervalBindingSource.DataMember = "Interval";
            this.intervalBindingSource.DataSource = this.diagramDBDataSet;
            // 
            // GraphEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.graphDataGridView);
            this.Controls.Add(this.graphBindingNavigator);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "GraphEditor";
            this.Text = "Graph Editor";
            this.Load += new System.EventHandler(this.DatabaseEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diagramDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphBindingNavigator)).EndInit();
            this.graphBindingNavigator.ResumeLayout(false);
            this.graphBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DiagramDBDataSet diagramDBDataSet;
        private System.Windows.Forms.BindingSource graphBindingSource;
        private DiagramDBDataSetTableAdapters.GraphTableAdapter graphTableAdapter;
        private DiagramDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator graphBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton graphBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView graphDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DiagramDBDataSetTableAdapters.IntervalTableAdapter intervalTableAdapter;
        private System.Windows.Forms.BindingSource intervalBindingSource;
    }
}