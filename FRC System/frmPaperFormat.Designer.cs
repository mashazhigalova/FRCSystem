namespace FRC_System
{
    partial class frmPaperFormat
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
            System.Windows.Forms.Label длина_страницыLabel;
            System.Windows.Forms.Label ширина_страницыLabel;
            System.Windows.Forms.Label формат_бумагиLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaperFormat));
            this.dgvPFormats = new System.Windows.Forms.DataGridView();
            this.paperformatidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paperformatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heigthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paperFormatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourcePF = new System.Windows.Forms.BindingSource(this.components);
            this.formatting_rules_DBDataSet = new FRC_System.formatting_rules_DBDataSet();
            this.butOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.tbWidgth = new System.Windows.Forms.TextBox();
            this.tbPaperFormat = new System.Windows.Forms.TextBox();
            this.формат_бумагиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.формат_бумагиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paperFormatTableAdapter = new FRC_System.formatting_rules_DBDataSetTableAdapters.PaperFormatTableAdapter();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            длина_страницыLabel = new System.Windows.Forms.Label();
            ширина_страницыLabel = new System.Windows.Forms.Label();
            формат_бумагиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPFormats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperFormatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formatting_rules_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.формат_бумагиBindingNavigator)).BeginInit();
            this.формат_бумагиBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // длина_страницыLabel
            // 
            длина_страницыLabel.AutoSize = true;
            длина_страницыLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            длина_страницыLabel.ForeColor = System.Drawing.Color.White;
            длина_страницыLabel.Location = new System.Drawing.Point(10, 78);
            длина_страницыLabel.Name = "длина_страницыLabel";
            длина_страницыLabel.Size = new System.Drawing.Size(103, 15);
            длина_страницыLabel.TabIndex = 12;
            длина_страницыLabel.Text = "Длина страницы:";
            // 
            // ширина_страницыLabel
            // 
            ширина_страницыLabel.AutoSize = true;
            ширина_страницыLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ширина_страницыLabel.ForeColor = System.Drawing.Color.White;
            ширина_страницыLabel.Location = new System.Drawing.Point(1, 52);
            ширина_страницыLabel.Name = "ширина_страницыLabel";
            ширина_страницыLabel.Size = new System.Drawing.Size(113, 15);
            ширина_страницыLabel.TabIndex = 10;
            ширина_страницыLabel.Text = "Ширина страницы:";
            // 
            // формат_бумагиLabel
            // 
            формат_бумагиLabel.AutoSize = true;
            формат_бумагиLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            формат_бумагиLabel.ForeColor = System.Drawing.Color.White;
            формат_бумагиLabel.Location = new System.Drawing.Point(17, 26);
            формат_бумагиLabel.Name = "формат_бумагиLabel";
            формат_бумагиLabel.Size = new System.Drawing.Size(96, 15);
            формат_бумагиLabel.TabIndex = 8;
            формат_бумагиLabel.Text = "Формат бумаги:";
            // 
            // dgvPFormats
            // 
            this.dgvPFormats.AllowUserToAddRows = false;
            this.dgvPFormats.AllowUserToDeleteRows = false;
            this.dgvPFormats.AutoGenerateColumns = false;
            this.dgvPFormats.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.dgvPFormats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPFormats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paperformatidDataGridViewTextBoxColumn,
            this.paperformatDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.heigthDataGridViewTextBoxColumn});
            this.dgvPFormats.DataSource = this.paperFormatBindingSource;
            this.dgvPFormats.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.dgvPFormats.Location = new System.Drawing.Point(228, 44);
            this.dgvPFormats.Name = "dgvPFormats";
            this.dgvPFormats.ReadOnly = true;
            this.dgvPFormats.Size = new System.Drawing.Size(343, 124);
            this.dgvPFormats.TabIndex = 0;
            // 
            // paperformatidDataGridViewTextBoxColumn
            // 
            this.paperformatidDataGridViewTextBoxColumn.DataPropertyName = "paper_format_id";
            this.paperformatidDataGridViewTextBoxColumn.HeaderText = "paper_format_id";
            this.paperformatidDataGridViewTextBoxColumn.Name = "paperformatidDataGridViewTextBoxColumn";
            this.paperformatidDataGridViewTextBoxColumn.ReadOnly = true;
            this.paperformatidDataGridViewTextBoxColumn.Visible = false;
            // 
            // paperformatDataGridViewTextBoxColumn
            // 
            this.paperformatDataGridViewTextBoxColumn.DataPropertyName = "paper_format";
            this.paperformatDataGridViewTextBoxColumn.HeaderText = "Формат бумаги";
            this.paperformatDataGridViewTextBoxColumn.Name = "paperformatDataGridViewTextBoxColumn";
            this.paperformatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "Ширина";
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            this.widthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // heigthDataGridViewTextBoxColumn
            // 
            this.heigthDataGridViewTextBoxColumn.DataPropertyName = "heigth";
            this.heigthDataGridViewTextBoxColumn.HeaderText = "Высота";
            this.heigthDataGridViewTextBoxColumn.Name = "heigthDataGridViewTextBoxColumn";
            this.heigthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paperFormatBindingSource
            // 
            this.paperFormatBindingSource.DataMember = "PaperFormat";
            this.paperFormatBindingSource.DataSource = this.bindingSourcePF;
            // 
            // bindingSourcePF
            // 
            this.bindingSourcePF.DataSource = this.formatting_rules_DBDataSet;
            this.bindingSourcePF.Position = 0;
            // 
            // formatting_rules_DBDataSet
            // 
            this.formatting_rules_DBDataSet.DataSetName = "formatting_rules_DBDataSet";
            this.formatting_rules_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // butOK
            // 
            this.butOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(196)))), ((int)(((byte)(234)))));
            this.butOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butOK.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butOK.ForeColor = System.Drawing.Color.White;
            this.butOK.Location = new System.Drawing.Point(159, 183);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(211, 23);
            this.butOK.TabIndex = 1;
            this.butOK.Text = "OK";
            this.butOK.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(167, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "мм";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(167, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "мм";
            // 
            // tbLength
            // 
            this.tbLength.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paperFormatBindingSource, "heigth", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.tbLength.Location = new System.Drawing.Point(118, 75);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(47, 23);
            this.tbLength.TabIndex = 13;
            this.tbLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLength_KeyPress);
            // 
            // tbWidgth
            // 
            this.tbWidgth.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paperFormatBindingSource, "width", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.tbWidgth.Location = new System.Drawing.Point(118, 49);
            this.tbWidgth.Name = "tbWidgth";
            this.tbWidgth.Size = new System.Drawing.Size(47, 23);
            this.tbWidgth.TabIndex = 11;
            this.tbWidgth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbWidgth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWidgth_KeyPress);
            // 
            // tbPaperFormat
            // 
            this.tbPaperFormat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paperFormatBindingSource, "paper_format", true));
            this.tbPaperFormat.Location = new System.Drawing.Point(118, 23);
            this.tbPaperFormat.Name = "tbPaperFormat";
            this.tbPaperFormat.Size = new System.Drawing.Size(47, 23);
            this.tbPaperFormat.TabIndex = 9;
            this.tbPaperFormat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPaperFormat_KeyPress);
            // 
            // формат_бумагиBindingNavigator
            // 
            this.формат_бумагиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.формат_бумагиBindingNavigator.BindingSource = this.paperFormatBindingSource;
            this.формат_бумагиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.формат_бумагиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.формат_бумагиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.формат_бумагиBindingNavigatorSaveItem});
            this.формат_бумагиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.формат_бумагиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.формат_бумагиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.формат_бумагиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.формат_бумагиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.формат_бумагиBindingNavigator.Name = "формат_бумагиBindingNavigator";
            this.формат_бумагиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.формат_бумагиBindingNavigator.Size = new System.Drawing.Size(583, 25);
            this.формат_бумагиBindingNavigator.TabIndex = 16;
            this.формат_бумагиBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // формат_бумагиBindingNavigatorSaveItem
            // 
            this.формат_бумагиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.формат_бумагиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("формат_бумагиBindingNavigatorSaveItem.Image")));
            this.формат_бумагиBindingNavigatorSaveItem.Name = "формат_бумагиBindingNavigatorSaveItem";
            this.формат_бумагиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.формат_бумагиBindingNavigatorSaveItem.Text = "Save Data";
            this.формат_бумагиBindingNavigatorSaveItem.Click += new System.EventHandler(this.формат_бумагиBindingNavigatorSaveItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.tbPaperFormat);
            this.panel1.Controls.Add(формат_бумагиLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbWidgth);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(ширина_страницыLabel);
            this.panel1.Controls.Add(длина_страницыLabel);
            this.panel1.Controls.Add(this.tbLength);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(19, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 124);
            this.panel1.TabIndex = 17;
            // 
            // paperFormatTableAdapter
            // 
            this.paperFormatTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(14, 33);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(561, 144);
            this.pictureBox7.TabIndex = 94;
            this.pictureBox7.TabStop = false;
            // 
            // frmPaperFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 215);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.формат_бумагиBindingNavigator);
            this.Controls.Add(this.butOK);
            this.Controls.Add(this.dgvPFormats);
            this.Controls.Add(this.pictureBox7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPaperFormat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Формат бумаги";
            this.Load += new System.EventHandler(this.frmPaperFormat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPFormats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperFormatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formatting_rules_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.формат_бумагиBindingNavigator)).EndInit();
            this.формат_бумагиBindingNavigator.ResumeLayout(false);
            this.формат_бумагиBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPFormats;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.TextBox tbWidgth;
        private System.Windows.Forms.TextBox tbPaperFormat;
        private System.Windows.Forms.BindingNavigator формат_бумагиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton формат_бумагиBindingNavigatorSaveItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bindingSourcePF;
        private formatting_rules_DBDataSet formatting_rules_DBDataSet;
        private System.Windows.Forms.BindingSource paperFormatBindingSource;
        private formatting_rules_DBDataSetTableAdapters.PaperFormatTableAdapter paperFormatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn paperformatidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paperformatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heigthDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}