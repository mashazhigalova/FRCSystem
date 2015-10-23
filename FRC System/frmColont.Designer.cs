namespace FRC_System
{
    partial class frmColont
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
            System.Windows.Forms.Label размер_верхнего_колонтитулаLabel;
            System.Windows.Forms.Label размер_нижнего_колонтитулаLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmColont));
            this.колонтитулBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.colontBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formatting_rules_DBDataSet = new FRC_System.formatting_rules_DBDataSet();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.колонтитулBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dgvColont = new System.Windows.Forms.DataGridView();
            this.colontidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bottomsizecolontDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upsizecolontDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btOK = new System.Windows.Forms.Button();
            this.tbUpCol = new System.Windows.Forms.TextBox();
            this.tbBottomCol = new System.Windows.Forms.TextBox();
            this.colontTableAdapter = new FRC_System.formatting_rules_DBDataSetTableAdapters.ColontTableAdapter();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            размер_верхнего_колонтитулаLabel = new System.Windows.Forms.Label();
            размер_нижнего_колонтитулаLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.колонтитулBindingNavigator)).BeginInit();
            this.колонтитулBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colontBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formatting_rules_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // размер_верхнего_колонтитулаLabel
            // 
            размер_верхнего_колонтитулаLabel.AutoSize = true;
            размер_верхнего_колонтитулаLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            размер_верхнего_колонтитулаLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            размер_верхнего_колонтитулаLabel.ForeColor = System.Drawing.Color.White;
            размер_верхнего_колонтитулаLabel.Location = new System.Drawing.Point(17, 66);
            размер_верхнего_колонтитулаLabel.Name = "размер_верхнего_колонтитулаLabel";
            размер_верхнего_колонтитулаLabel.Size = new System.Drawing.Size(183, 15);
            размер_верхнего_колонтитулаLabel.TabIndex = 28;
            размер_верхнего_колонтитулаLabel.Text = "Размер верхнего колонтитула:";
            // 
            // размер_нижнего_колонтитулаLabel
            // 
            размер_нижнего_колонтитулаLabel.AutoSize = true;
            размер_нижнего_колонтитулаLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            размер_нижнего_колонтитулаLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            размер_нижнего_колонтитулаLabel.ForeColor = System.Drawing.Color.White;
            размер_нижнего_колонтитулаLabel.Location = new System.Drawing.Point(17, 40);
            размер_нижнего_колонтитулаLabel.Name = "размер_нижнего_колонтитулаLabel";
            размер_нижнего_колонтитулаLabel.Size = new System.Drawing.Size(180, 15);
            размер_нижнего_колонтитулаLabel.TabIndex = 25;
            размер_нижнего_колонтитулаLabel.Text = "Размер нижнего колонтитула:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(258, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(22, 15);
            label1.TabIndex = 25;
            label1.Text = "см";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(258, 65);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(22, 15);
            label2.TabIndex = 25;
            label2.Text = "см";
            // 
            // колонтитулBindingNavigator
            // 
            this.колонтитулBindingNavigator.AddNewItem = this.toolStripButton1;
            this.колонтитулBindingNavigator.BindingSource = this.colontBindingSource;
            this.колонтитулBindingNavigator.CountItem = this.toolStripLabel1;
            this.колонтитулBindingNavigator.DeleteItem = this.toolStripButton2;
            this.колонтитулBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.колонтитулBindingNavigatorSaveItem});
            this.колонтитулBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.колонтитулBindingNavigator.MoveFirstItem = this.toolStripButton3;
            this.колонтитулBindingNavigator.MoveLastItem = this.toolStripButton6;
            this.колонтитулBindingNavigator.MoveNextItem = this.toolStripButton5;
            this.колонтитулBindingNavigator.MovePreviousItem = this.toolStripButton4;
            this.колонтитулBindingNavigator.Name = "колонтитулBindingNavigator";
            this.колонтитулBindingNavigator.PositionItem = this.toolStripTextBox1;
            this.колонтитулBindingNavigator.Size = new System.Drawing.Size(333, 25);
            this.колонтитулBindingNavigator.TabIndex = 1;
            this.колонтитулBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Add new";
            // 
            // colontBindingSource
            // 
            this.colontBindingSource.DataMember = "Colont";
            this.colontBindingSource.DataSource = this.formatting_rules_DBDataSet;
            // 
            // formatting_rules_DBDataSet
            // 
            this.formatting_rules_DBDataSet.DataSetName = "formatting_rules_DBDataSet";
            this.formatting_rules_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Delete";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move first";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Move next";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // колонтитулBindingNavigatorSaveItem
            // 
            this.колонтитулBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.колонтитулBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("колонтитулBindingNavigatorSaveItem.Image")));
            this.колонтитулBindingNavigatorSaveItem.Name = "колонтитулBindingNavigatorSaveItem";
            this.колонтитулBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.колонтитулBindingNavigatorSaveItem.Text = "Save Data";
            this.колонтитулBindingNavigatorSaveItem.Click += new System.EventHandler(this.колонтитулBindingNavigatorSaveItem_Click);
            // 
            // dgvColont
            // 
            this.dgvColont.AllowUserToAddRows = false;
            this.dgvColont.AllowUserToDeleteRows = false;
            this.dgvColont.AllowUserToResizeColumns = false;
            this.dgvColont.AllowUserToResizeRows = false;
            this.dgvColont.AutoGenerateColumns = false;
            this.dgvColont.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvColont.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvColont.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColont.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colontidDataGridViewTextBoxColumn,
            this.bottomsizecolontDataGridViewTextBoxColumn,
            this.upsizecolontDataGridViewTextBoxColumn});
            this.dgvColont.DataSource = this.colontBindingSource;
            this.dgvColont.Location = new System.Drawing.Point(20, 89);
            this.dgvColont.MultiSelect = false;
            this.dgvColont.Name = "dgvColont";
            this.dgvColont.ReadOnly = true;
            this.dgvColont.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColont.Size = new System.Drawing.Size(289, 135);
            this.dgvColont.TabIndex = 30;
            // 
            // colontidDataGridViewTextBoxColumn
            // 
            this.colontidDataGridViewTextBoxColumn.DataPropertyName = "colont_id";
            this.colontidDataGridViewTextBoxColumn.HeaderText = "colont_id";
            this.colontidDataGridViewTextBoxColumn.Name = "colontidDataGridViewTextBoxColumn";
            this.colontidDataGridViewTextBoxColumn.ReadOnly = true;
            this.colontidDataGridViewTextBoxColumn.Visible = false;
            this.colontidDataGridViewTextBoxColumn.Width = 75;
            // 
            // bottomsizecolontDataGridViewTextBoxColumn
            // 
            this.bottomsizecolontDataGridViewTextBoxColumn.DataPropertyName = "bottom_size_colont";
            this.bottomsizecolontDataGridViewTextBoxColumn.HeaderText = "Нижний колонтитул";
            this.bottomsizecolontDataGridViewTextBoxColumn.Name = "bottomsizecolontDataGridViewTextBoxColumn";
            this.bottomsizecolontDataGridViewTextBoxColumn.ReadOnly = true;
            this.bottomsizecolontDataGridViewTextBoxColumn.Width = 121;
            // 
            // upsizecolontDataGridViewTextBoxColumn
            // 
            this.upsizecolontDataGridViewTextBoxColumn.DataPropertyName = "up_size_colont";
            this.upsizecolontDataGridViewTextBoxColumn.HeaderText = "Верхний колонтитул";
            this.upsizecolontDataGridViewTextBoxColumn.Name = "upsizecolontDataGridViewTextBoxColumn";
            this.upsizecolontDataGridViewTextBoxColumn.ReadOnly = true;
            this.upsizecolontDataGridViewTextBoxColumn.Width = 123;
            // 
            // btOK
            // 
            this.btOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(196)))), ((int)(((byte)(234)))));
            this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btOK.ForeColor = System.Drawing.Color.White;
            this.btOK.Location = new System.Drawing.Point(91, 236);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(131, 23);
            this.btOK.TabIndex = 29;
            this.btOK.Text = "Выбрать";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // tbUpCol
            // 
            this.tbUpCol.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colontBindingSource, "up_size_colont", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tbUpCol.Location = new System.Drawing.Point(200, 63);
            this.tbUpCol.Name = "tbUpCol";
            this.tbUpCol.Size = new System.Drawing.Size(58, 20);
            this.tbUpCol.TabIndex = 27;
            this.tbUpCol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUpCol_KeyPress);
            // 
            // tbBottomCol
            // 
            this.tbBottomCol.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colontBindingSource, "bottom_size_colont", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tbBottomCol.Location = new System.Drawing.Point(200, 37);
            this.tbBottomCol.Name = "tbBottomCol";
            this.tbBottomCol.Size = new System.Drawing.Size(58, 20);
            this.tbBottomCol.TabIndex = 26;
            this.tbBottomCol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBottomCol_KeyPress);
            // 
            // colontTableAdapter
            // 
            this.colontTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(10, 35);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(314, 197);
            this.pictureBox7.TabIndex = 93;
            this.pictureBox7.TabStop = false;
            // 
            // frmColont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 263);
            this.ControlBox = false;
            this.Controls.Add(this.dgvColont);
            this.Controls.Add(this.btOK);
            this.Controls.Add(размер_верхнего_колонтитулаLabel);
            this.Controls.Add(this.tbUpCol);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(размер_нижнего_колонтитулаLabel);
            this.Controls.Add(this.tbBottomCol);
            this.Controls.Add(this.колонтитулBindingNavigator);
            this.Controls.Add(this.pictureBox7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmColont";
            this.Text = "Колонтитулы";
            this.Load += new System.EventHandler(this.frmColont_Load);
            ((System.ComponentModel.ISupportInitialize)(this.колонтитулBindingNavigator)).EndInit();
            this.колонтитулBindingNavigator.ResumeLayout(false);
            this.колонтитулBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colontBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formatting_rules_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator колонтитулBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton колонтитулBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dgvColont;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.TextBox tbUpCol;
        private System.Windows.Forms.TextBox tbBottomCol;
        private formatting_rules_DBDataSet formatting_rules_DBDataSet;
        private System.Windows.Forms.BindingSource colontBindingSource;
        private formatting_rules_DBDataSetTableAdapters.ColontTableAdapter colontTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colontidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bottomsizecolontDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn upsizecolontDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox7;

    }
}