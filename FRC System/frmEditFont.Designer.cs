namespace FRC_System
{
    partial class frmEditFont
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditFont));
            this.btnSave = new System.Windows.Forms.Button();
            this.gbNachert = new System.Windows.Forms.GroupBox();
            this.chbZh = new System.Windows.Forms.CheckBox();
            this.chbCurs = new System.Windows.Forms.CheckBox();
            this.chPodch = new System.Windows.Forms.CheckBox();
            this.gbFontParams = new System.Windows.Forms.GroupBox();
            this.numFontSize = new System.Windows.Forms.NumericUpDown();
            this.cbFontColor = new System.Windows.Forms.ComboBox();
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formatting_rules_DBDataSet = new FRC_System.formatting_rules_DBDataSet();
            this.cbFontName = new System.Windows.Forms.ComboBox();
            this.fontTitleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fontTitleTableAdapter = new FRC_System.formatting_rules_DBDataSetTableAdapters.FontTitleTableAdapter();
            this.colorTableAdapter = new FRC_System.formatting_rules_DBDataSetTableAdapters.ColorTableAdapter();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            размерLabel = new System.Windows.Forms.Label();
            цветLabel = new System.Windows.Forms.Label();
            название_шрифтаLabel = new System.Windows.Forms.Label();
            this.gbNachert.SuspendLayout();
            this.gbFontParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formatting_rules_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontTitleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // размерLabel
            // 
            размерLabel.AutoSize = true;
            размерLabel.Location = new System.Drawing.Point(61, 28);
            размерLabel.Name = "размерLabel";
            размерLabel.Size = new System.Drawing.Size(51, 15);
            размерLabel.TabIndex = 6;
            размерLabel.Text = "Размер:";
            // 
            // цветLabel
            // 
            цветLabel.AutoSize = true;
            цветLabel.Location = new System.Drawing.Point(74, 96);
            цветLabel.Name = "цветLabel";
            цветLabel.Size = new System.Drawing.Size(37, 15);
            цветLabel.TabIndex = 4;
            цветLabel.Text = "Цвет:";
            // 
            // название_шрифтаLabel
            // 
            название_шрифтаLabel.AutoSize = true;
            название_шрифтаLabel.Location = new System.Drawing.Point(2, 60);
            название_шрифтаLabel.Name = "название_шрифтаLabel";
            название_шрифтаLabel.Size = new System.Drawing.Size(111, 15);
            название_шрифтаLabel.TabIndex = 3;
            название_шрифтаLabel.Text = "Название шрифта:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(196)))), ((int)(((byte)(234)))));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(51, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(183, 27);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbNachert
            // 
            this.gbNachert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.gbNachert.Controls.Add(this.chbZh);
            this.gbNachert.Controls.Add(this.chbCurs);
            this.gbNachert.Controls.Add(this.chPodch);
            this.gbNachert.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbNachert.ForeColor = System.Drawing.Color.White;
            this.gbNachert.Location = new System.Drawing.Point(14, 137);
            this.gbNachert.Name = "gbNachert";
            this.gbNachert.Size = new System.Drawing.Size(258, 65);
            this.gbNachert.TabIndex = 38;
            this.gbNachert.TabStop = false;
            this.gbNachert.Text = "Начертание";
            // 
            // chbZh
            // 
            this.chbZh.Location = new System.Drawing.Point(137, 15);
            this.chbZh.Name = "chbZh";
            this.chbZh.Size = new System.Drawing.Size(104, 24);
            this.chbZh.TabIndex = 3;
            this.chbZh.Text = "Полужирный";
            this.chbZh.UseVisualStyleBackColor = true;
            // 
            // chbCurs
            // 
            this.chbCurs.Location = new System.Drawing.Point(7, 15);
            this.chbCurs.Name = "chbCurs";
            this.chbCurs.Size = new System.Drawing.Size(104, 24);
            this.chbCurs.TabIndex = 1;
            this.chbCurs.Text = "Курсив";
            this.chbCurs.UseVisualStyleBackColor = true;
            // 
            // chPodch
            // 
            this.chPodch.Location = new System.Drawing.Point(7, 38);
            this.chPodch.Name = "chPodch";
            this.chPodch.Size = new System.Drawing.Size(104, 24);
            this.chPodch.TabIndex = 2;
            this.chPodch.Text = "Подчеркнутый";
            this.chPodch.UseVisualStyleBackColor = true;
            // 
            // gbFontParams
            // 
            this.gbFontParams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.gbFontParams.Controls.Add(размерLabel);
            this.gbFontParams.Controls.Add(this.numFontSize);
            this.gbFontParams.Controls.Add(цветLabel);
            this.gbFontParams.Controls.Add(this.cbFontColor);
            this.gbFontParams.Controls.Add(название_шрифтаLabel);
            this.gbFontParams.Controls.Add(this.cbFontName);
            this.gbFontParams.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbFontParams.ForeColor = System.Drawing.Color.White;
            this.gbFontParams.Location = new System.Drawing.Point(12, 12);
            this.gbFontParams.Name = "gbFontParams";
            this.gbFontParams.Size = new System.Drawing.Size(260, 119);
            this.gbFontParams.TabIndex = 37;
            this.gbFontParams.TabStop = false;
            this.gbFontParams.Text = "Параметры шрифта";
            // 
            // numFontSize
            // 
            this.numFontSize.DecimalPlaces = 2;
            this.numFontSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numFontSize.Location = new System.Drawing.Point(115, 26);
            this.numFontSize.Name = "numFontSize";
            this.numFontSize.Size = new System.Drawing.Size(49, 23);
            this.numFontSize.TabIndex = 7;
            this.numFontSize.ThousandsSeparator = true;
            this.numFontSize.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // cbFontColor
            // 
            this.cbFontColor.DataSource = this.colorBindingSource;
            this.cbFontColor.DisplayMember = "color";
            this.cbFontColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFontColor.FormattingEnabled = true;
            this.cbFontColor.Location = new System.Drawing.Point(114, 93);
            this.cbFontColor.Name = "cbFontColor";
            this.cbFontColor.Size = new System.Drawing.Size(121, 23);
            this.cbFontColor.TabIndex = 5;
            this.cbFontColor.ValueMember = "color_id";
            // 
            // colorBindingSource
            // 
            this.colorBindingSource.DataMember = "Color";
            this.colorBindingSource.DataSource = this.formatting_rules_DBDataSet;
            // 
            // formatting_rules_DBDataSet
            // 
            this.formatting_rules_DBDataSet.DataSetName = "formatting_rules_DBDataSet";
            this.formatting_rules_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbFontName
            // 
            this.cbFontName.DataSource = this.fontTitleBindingSource;
            this.cbFontName.DisplayMember = "font_title";
            this.cbFontName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFontName.FormattingEnabled = true;
            this.cbFontName.Location = new System.Drawing.Point(114, 57);
            this.cbFontName.Name = "cbFontName";
            this.cbFontName.Size = new System.Drawing.Size(121, 23);
            this.cbFontName.TabIndex = 4;
            this.cbFontName.ValueMember = "font_title_id";
            // 
            // fontTitleBindingSource
            // 
            this.fontTitleBindingSource.DataMember = "FontTitle";
            this.fontTitleBindingSource.DataSource = this.formatting_rules_DBDataSet;
            // 
            // fontTitleTableAdapter
            // 
            this.fontTitleTableAdapter.ClearBeforeFill = true;
            // 
            // colorTableAdapter
            // 
            this.colorTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(4, 7);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(279, 207);
            this.pictureBox7.TabIndex = 93;
            this.pictureBox7.TabStop = false;
            // 
            // frmEditFont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 253);
            this.Controls.Add(this.gbNachert);
            this.Controls.Add(this.gbFontParams);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEditFont";
            this.Text = "Добавить/изменить шрифт";
            this.Load += new System.EventHandler(this.frmEditFont_Load);
            this.gbNachert.ResumeLayout(false);
            this.gbFontParams.ResumeLayout(false);
            this.gbFontParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formatting_rules_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontTitleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbNachert;
        private System.Windows.Forms.CheckBox chbZh;
        private System.Windows.Forms.CheckBox chbCurs;
        private System.Windows.Forms.CheckBox chPodch;
        private System.Windows.Forms.GroupBox gbFontParams;
        private System.Windows.Forms.NumericUpDown numFontSize;
        private System.Windows.Forms.ComboBox cbFontColor;
        private System.Windows.Forms.ComboBox cbFontName;
        private formatting_rules_DBDataSet formatting_rules_DBDataSet;
        private System.Windows.Forms.BindingSource fontTitleBindingSource;
        private formatting_rules_DBDataSetTableAdapters.FontTitleTableAdapter fontTitleTableAdapter;
        private System.Windows.Forms.BindingSource colorBindingSource;
        private formatting_rules_DBDataSetTableAdapters.ColorTableAdapter colorTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}