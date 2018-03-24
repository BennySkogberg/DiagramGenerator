namespace DiagramGenerator
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortXValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortYValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxAddPoint = new System.Windows.Forms.GroupBox();
            this.btnAddValue = new System.Windows.Forms.Button();
            this.tbxYValue = new System.Windows.Forms.TextBox();
            this.tbxXValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxSettings = new System.Windows.Forms.GroupBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxYStep = new System.Windows.Forms.TextBox();
            this.tbxYInterval = new System.Windows.Forms.TextBox();
            this.tbxXStep = new System.Windows.Forms.TextBox();
            this.tbxXInterval = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbxRandom = new System.Windows.Forms.GroupBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.numUpDownRandom = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.gbxAddPoint.SuspendLayout();
            this.gbxSettings.SuspendLayout();
            this.gbxRandom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRandom)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.loadToolStripMenuItem.Text = "&Load last graph";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortXValueToolStripMenuItem,
            this.sortYValuesToolStripMenuItem,
            this.databaseEditorToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // sortXValueToolStripMenuItem
            // 
            this.sortXValueToolStripMenuItem.Name = "sortXValueToolStripMenuItem";
            this.sortXValueToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.sortXValueToolStripMenuItem.Text = "Sort x value";
            this.sortXValueToolStripMenuItem.Click += new System.EventHandler(this.sortXValueToolStripMenuItem_Click);
            // 
            // sortYValuesToolStripMenuItem
            // 
            this.sortYValuesToolStripMenuItem.Name = "sortYValuesToolStripMenuItem";
            this.sortYValuesToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.sortYValuesToolStripMenuItem.Text = "Sort y values";
            this.sortYValuesToolStripMenuItem.Click += new System.EventHandler(this.sortYValuesToolStripMenuItem_Click);
            // 
            // databaseEditorToolStripMenuItem
            // 
            this.databaseEditorToolStripMenuItem.Name = "databaseEditorToolStripMenuItem";
            this.databaseEditorToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.databaseEditorToolStripMenuItem.Text = "Graph Editor";
            this.databaseEditorToolStripMenuItem.Click += new System.EventHandler(this.databaseEditorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // gbxAddPoint
            // 
            this.gbxAddPoint.Controls.Add(this.btnAddValue);
            this.gbxAddPoint.Controls.Add(this.tbxYValue);
            this.gbxAddPoint.Controls.Add(this.tbxXValue);
            this.gbxAddPoint.Controls.Add(this.label2);
            this.gbxAddPoint.Controls.Add(this.label1);
            this.gbxAddPoint.Location = new System.Drawing.Point(13, 28);
            this.gbxAddPoint.Name = "gbxAddPoint";
            this.gbxAddPoint.Size = new System.Drawing.Size(200, 124);
            this.gbxAddPoint.TabIndex = 1;
            this.gbxAddPoint.TabStop = false;
            this.gbxAddPoint.Text = "Add Point";
            // 
            // btnAddValue
            // 
            this.btnAddValue.Location = new System.Drawing.Point(81, 83);
            this.btnAddValue.Name = "btnAddValue";
            this.btnAddValue.Size = new System.Drawing.Size(75, 23);
            this.btnAddValue.TabIndex = 4;
            this.btnAddValue.Text = "&Add Point";
            this.btnAddValue.UseVisualStyleBackColor = true;
            this.btnAddValue.Click += new System.EventHandler(this.btnAddValue_Click);
            // 
            // tbxYValue
            // 
            this.tbxYValue.Location = new System.Drawing.Point(94, 47);
            this.tbxYValue.Name = "tbxYValue";
            this.tbxYValue.Size = new System.Drawing.Size(62, 20);
            this.tbxYValue.TabIndex = 3;
            // 
            // tbxXValue
            // 
            this.tbxXValue.Location = new System.Drawing.Point(94, 20);
            this.tbxXValue.Name = "tbxXValue";
            this.tbxXValue.Size = new System.Drawing.Size(62, 20);
            this.tbxXValue.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y-coordinate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X-coordinate";
            // 
            // gbxSettings
            // 
            this.gbxSettings.Controls.Add(this.btnDone);
            this.gbxSettings.Controls.Add(this.label6);
            this.gbxSettings.Controls.Add(this.label5);
            this.gbxSettings.Controls.Add(this.label4);
            this.gbxSettings.Controls.Add(this.label3);
            this.gbxSettings.Controls.Add(this.tbxYStep);
            this.gbxSettings.Controls.Add(this.tbxYInterval);
            this.gbxSettings.Controls.Add(this.tbxXStep);
            this.gbxSettings.Controls.Add(this.tbxXInterval);
            this.gbxSettings.Location = new System.Drawing.Point(12, 158);
            this.gbxSettings.Name = "gbxSettings";
            this.gbxSettings.Size = new System.Drawing.Size(201, 211);
            this.gbxSettings.TabIndex = 2;
            this.gbxSettings.TabStop = false;
            this.gbxSettings.Text = "Settings";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(82, 168);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 8;
            this.btnDone.Text = "&Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Y interval step";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "no of Y interval";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "X interval step";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "no of X interval";
            // 
            // tbxYStep
            // 
            this.tbxYStep.Location = new System.Drawing.Point(95, 131);
            this.tbxYStep.Name = "tbxYStep";
            this.tbxYStep.Size = new System.Drawing.Size(62, 20);
            this.tbxYStep.TabIndex = 3;
            // 
            // tbxYInterval
            // 
            this.tbxYInterval.Location = new System.Drawing.Point(95, 104);
            this.tbxYInterval.Name = "tbxYInterval";
            this.tbxYInterval.Size = new System.Drawing.Size(62, 20);
            this.tbxYInterval.TabIndex = 2;
            // 
            // tbxXStep
            // 
            this.tbxXStep.Location = new System.Drawing.Point(95, 58);
            this.tbxXStep.Name = "tbxXStep";
            this.tbxXStep.Size = new System.Drawing.Size(62, 20);
            this.tbxXStep.TabIndex = 1;
            // 
            // tbxXInterval
            // 
            this.tbxXInterval.Location = new System.Drawing.Point(95, 31);
            this.tbxXInterval.Name = "tbxXInterval";
            this.tbxXInterval.Size = new System.Drawing.Size(62, 20);
            this.tbxXInterval.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(13, 392);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(200, 40);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gbxRandom
            // 
            this.gbxRandom.Controls.Add(this.btnRandom);
            this.gbxRandom.Controls.Add(this.numUpDownRandom);
            this.gbxRandom.Location = new System.Drawing.Point(13, 451);
            this.gbxRandom.Name = "gbxRandom";
            this.gbxRandom.Size = new System.Drawing.Size(200, 143);
            this.gbxRandom.TabIndex = 10;
            this.gbxRandom.TabStop = false;
            this.gbxRandom.Text = "Random";
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(80, 82);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(76, 34);
            this.btnRandom.TabIndex = 1;
            this.btnRandom.Text = "Randomi&ze";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // numUpDownRandom
            // 
            this.numUpDownRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownRandom.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDownRandom.Location = new System.Drawing.Point(80, 33);
            this.numUpDownRandom.Name = "numUpDownRandom";
            this.numUpDownRandom.Size = new System.Drawing.Size(76, 31);
            this.numUpDownRandom.TabIndex = 0;
            this.numUpDownRandom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDownRandom.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 606);
            this.Controls.Add(this.gbxRandom);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gbxSettings);
            this.Controls.Add(this.gbxAddPoint);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(895, 640);
            this.MinimumSize = new System.Drawing.Size(895, 640);
            this.Name = "MainForm";
            this.Text = "Diagram Generator";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxAddPoint.ResumeLayout(false);
            this.gbxAddPoint.PerformLayout();
            this.gbxSettings.ResumeLayout(false);
            this.gbxSettings.PerformLayout();
            this.gbxRandom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRandom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortXValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortYValuesToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbxAddPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxSettings;
        private System.Windows.Forms.Button btnAddValue;
        private System.Windows.Forms.TextBox tbxYValue;
        private System.Windows.Forms.TextBox tbxXValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxYStep;
        private System.Windows.Forms.TextBox tbxYInterval;
        private System.Windows.Forms.TextBox tbxXStep;
        private System.Windows.Forms.TextBox tbxXInterval;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseEditorToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbxRandom;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.NumericUpDown numUpDownRandom;
    }
}

