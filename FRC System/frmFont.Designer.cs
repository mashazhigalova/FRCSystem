namespace FRC_System
{
    partial class frmFont
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
            System.Windows.Forms.Label размерLabel;
            System.Windows.Forms.Label цветLabel;
            System.Windows.Forms.Label название_шрифтаLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFont));
            this.gbNachert = new System.Windows.Forms.GroupBox();
            this.chbZh = new System.Windows.Forms.CheckBox();
            this.chbCurs = new System.Windows.Forms.CheckBox();
            this.chPodch = new System.Windows.Forms.CheckBox();
            this.fontBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bindingNavigatorEditItem = new System.Windows.Forms.ToolStripButton();
            this.gbFont = new System.Windows.Forms.GroupBox();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.tbFTitle = new System.Windows.Forms.TextBox();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            размерLabel = new System.Windows.Forms.Label();
            цветLabel = new System.Windows.Forms.Label();
            название_шрифтаLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.gbNachert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontBindingNavigator)).BeginInit();
            this.fontBindingNavigator.SuspendLayout();
            this.gbFont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // размерLabel
            // 
            размерLabel.AutoSize = true;
            размерLabel.Location = new System.Drawing.Point(73, 17);
            размерLabel.Name = "размерLabel";
            размерLabel.Size = new System.Drawing.Size(51, 15);
            размерLabel.TabIndex = 39;
            размерLabel.Text = "Размер:";
            // 
            // цветLabel
            // 
            цветLabel.AutoSize = true;
            цветLabel.Location = new System.Drawing.Point(86, 61);
            цветLabel.Name = "цветLabel";
            цветLabel.Size = new System.Drawing.Size(37, 15);
            цветLabel.TabIndex = 38;
            цветLabel.Text = "Цвет:";
            // 
            // название_шрифтаLabel
            // 
            название_шрифтаLabel.AutoSize = true;
            название_шрифтаLabel.Location = new System.Drawing.Point(12, 41);
            название_шрифтаLabel.Name = "название_шрифтаLabel";
            название_шрифтаLabel.Size = new System.Drawing.Size(111, 15);
            название_шрифтаLabel.TabIndex = 37;
            название_шрифтаLabel.Text = "Название шрифта:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(173, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(19, 15);
            label1.TabIndex = 39;
            label1.Text = "пт";
            // 
            // gbNachert
            // 
            this.gbNachert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.gbNachert.Controls.Add(this.chbZh);
            this.gbNachert.Controls.Add(this.chbCurs);
            this.gbNachert.Controls.Add(this.chPodch);
            this.gbNachert.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbNachert.ForeColor = System.Drawing.Color.White;
            this.gbNachert.Location = new System.Drawing.Point(17, 124);
            this.gbNachert.Name = "gbNachert";
            this.gbNachert.Size = new System.Drawing.Size(284, 67);
            this.gbNachert.TabIndex = 40;
            this.gbNachert.TabStop = false;
            this.gbNachert.Text = "Начертание";
            // 
            // chbZh
            // 
            this.chbZh.AutoCheck = false;
            this.chbZh.Location = new System.Drawing.Point(118, 15);
            this.chbZh.Name = "chbZh";
            this.chbZh.Size = new System.Drawing.Size(104, 24);
            this.chbZh.TabIndex = 3;
            this.chbZh.TabStop = false;
            this.chbZh.Text = "Полужирный";
            this.chbZh.UseVisualStyleBackColor = true;
            // 
            // chbCurs
            // 
            this.chbCurs.AutoCheck = false;
            this.chbCurs.Location = new System.Drawing.Point(7, 15);
            this.chbCurs.Name = "chbCurs";
            this.chbCurs.Size = new System.Drawing.Size(104, 24);
            this.chbCurs.TabIndex = 23;
            this.chbCurs.TabStop = false;
            this.chbCurs.Text = "Курсив";
            this.chbCurs.UseVisualStyleBackColor = true;
            // 
            // chPodch
            // 
            this.chPodch.AutoCheck = false;
            this.chPodch.Location = new System.Drawing.Point(7, 38);
            this.chPodch.Name = "chPodch";
            this.chPodch.Size = new System.Drawing.Size(118, 24);
            this.chPodch.TabIndex = 2;
            this.chPodch.TabStop = false;
            this.chPodch.Text = "Подчеркнутый";
            this.chPodch.UseVisualStyleBackColor = true;
            // 
            // fontBindingNavigator
            // 
            this.fontBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fontBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fontBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fontBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorEditItem,
            this.bindingNavigatorDeleteItem});
            this.fontBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fontBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fontBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fontBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fontBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fontBindingNavigator.Name = "fontBindingNavigator";
            this.fontBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fontBindingNavigator.Size = new System.Drawing.Size(315, 25);
            this.fontBindingNavigator.TabIndex = 41;
            this.fontBindingNavigator.Text = "bindingNavigator1";
            this.fontBindingNavigator.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fontBindingNavigator_ItemClicked);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            this.bindingNavigatorMoveLastItem.Text = " ";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorEditItem
            // 
            this.bindingNavigatorEditItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorEditItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorEditItem.Image")));
            this.bindingNavigatorEditItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorEditItem.Name = "bindingNavigatorEditItem";
            this.bindingNavigatorEditItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorEditItem.Text = "Edit";
            this.bindingNavigatorEditItem.Click += new System.EventHandler(this.bindingNavigatorEditItem_Click);
            // 
            // gbFont
            // 
            this.gbFont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.gbFont.Controls.Add(this.tbColor);
            this.gbFont.Controls.Add(this.tbFTitle);
            this.gbFont.Controls.Add(this.tbSize);
            this.gbFont.Controls.Add(label1);
            this.gbFont.Controls.Add(размерLabel);
            this.gbFont.Controls.Add(название_шрифтаLabel);
            this.gbFont.Controls.Add(цветLabel);
            this.gbFont.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbFont.ForeColor = System.Drawing.Color.White;
            this.gbFont.Location = new System.Drawing.Point(18, 39);
            this.gbFont.Name = "gbFont";
            this.gbFont.Size = new System.Drawing.Size(283, 79);
            this.gbFont.TabIndex = 42;
            this.gbFont.TabStop = false;
            this.gbFont.Text = "Общее";
            // 
            // tbColor
            // 
            this.tbColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.tbColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbColor.ForeColor = System.Drawing.Color.White;
            this.tbColor.Location = new System.Drawing.Point(127, 61);
            this.tbColor.Name = "tbColor";
            this.tbColor.ReadOnly = true;
            this.tbColor.Size = new System.Drawing.Size(112, 16);
            this.tbColor.TabIndex = 40;
            this.tbColor.TabStop = false;
            // 
            // tbFTitle
            // 
            this.tbFTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.tbFTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFTitle.ForeColor = System.Drawing.Color.White;
            this.tbFTitle.Location = new System.Drawing.Point(127, 41);
            this.tbFTitle.Name = "tbFTitle";
            this.tbFTitle.ReadOnly = true;
            this.tbFTitle.Size = new System.Drawing.Size(112, 16);
            this.tbFTitle.TabIndex = 40;
            this.tbFTitle.TabStop = false;
            // 
            // tbSize
            // 
            this.tbSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.tbSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSize.ForeColor = System.Drawing.Color.White;
            this.tbSize.Location = new System.Drawing.Point(127, 17);
            this.tbSize.Name = "tbSize";
            this.tbSize.ReadOnly = true;
            this.tbSize.Size = new System.Drawing.Size(40, 16);
            this.tbSize.TabIndex = 40;
            this.tbSize.TabStop = false;
            // 
            // btOK
            // 
            this.btOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(196)))), ((int)(((byte)(234)))));
            this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOK.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btOK.ForeColor = System.Drawing.Color.White;
            this.btOK.Location = new System.Drawing.Point(51, 206);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(201, 23);
            this.btOK.TabIndex = 1;
            this.btOK.Text = "Выбрать";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(12, 28);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(294, 172);
            this.pictureBox7.TabIndex = 95;
            this.pictureBox7.TabStop = false;
            // 
            // frmFont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 236);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.gbFont);
            this.Controls.Add(this.fontBindingNavigator);
            this.Controls.Add(this.gbNachert);
            this.Controls.Add(this.pictureBox7);
            this.Name = "frmFont";
            this.Text = "Шрифт";
            this.Load += new System.EventHandler(this.frmFont_Load);
            this.gbNachert.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fontBindingNavigator)).EndInit();
            this.fontBindingNavigator.ResumeLayout(false);
            this.fontBindingNavigator.PerformLayout();
            this.gbFont.ResumeLayout(false);
            this.gbFont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNachert;
        private System.Windows.Forms.CheckBox chbZh;
        private System.Windows.Forms.CheckBox chbCurs;
        private System.Windows.Forms.CheckBox chPodch;
        private System.Windows.Forms.BindingNavigator fontBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bindingNavigatorEditItem;
        private System.Windows.Forms.GroupBox gbFont;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.TextBox tbFTitle;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}