namespace FRC_System
{
    partial class frmEditPar
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
            System.Windows.Forms.Label интервал_после_абзацаLabel;
            System.Windows.Forms.Label интервал_перед_абзацемLabel;
            System.Windows.Forms.Label междустрочный_интервалLabel;
            System.Windows.Forms.Label размер_отступа_1_ой_строкиLabel;
            System.Windows.Forms.Label размер_отступа_справаLabel;
            System.Windows.Forms.Label размер_отступа_слеваLabel;
            System.Windows.Forms.Label выравниваниеLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditPar));
            this.gbInt = new System.Windows.Forms.GroupBox();
            this.numStrInt = new System.Windows.Forms.NumericUpDown();
            this.numAfter = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numBefore = new System.Windows.Forms.NumericUpDown();
            this.gbOtst = new System.Windows.Forms.GroupBox();
            this.numOtst = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numRight = new System.Windows.Forms.NumericUpDown();
            this.numLeft = new System.Windows.Forms.NumericUpDown();
            this.cbAlign = new System.Windows.Forms.ComboBox();
            this.alignmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formatting_rules_DBDataSet = new FRC_System.formatting_rules_DBDataSet();
            this.btnSave = new System.Windows.Forms.Button();
            this.alignmentTableAdapter = new FRC_System.formatting_rules_DBDataSetTableAdapters.AlignmentTableAdapter();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            интервал_после_абзацаLabel = new System.Windows.Forms.Label();
            интервал_перед_абзацемLabel = new System.Windows.Forms.Label();
            междустрочный_интервалLabel = new System.Windows.Forms.Label();
            размер_отступа_1_ой_строкиLabel = new System.Windows.Forms.Label();
            размер_отступа_справаLabel = new System.Windows.Forms.Label();
            размер_отступа_слеваLabel = new System.Windows.Forms.Label();
            выравниваниеLabel = new System.Windows.Forms.Label();
            this.gbInt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStrInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBefore)).BeginInit();
            this.gbOtst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOtst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formatting_rules_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // интервал_после_абзацаLabel
            // 
            интервал_после_абзацаLabel.AutoSize = true;
            интервал_после_абзацаLabel.Location = new System.Drawing.Point(11, 64);
            интервал_после_абзацаLabel.Name = "интервал_после_абзацаLabel";
            интервал_после_абзацаLabel.Size = new System.Drawing.Size(45, 15);
            интервал_после_абзацаLabel.TabIndex = 0;
            интервал_после_абзацаLabel.Text = "После:";
            // 
            // интервал_перед_абзацемLabel
            // 
            интервал_перед_абзацемLabel.AutoSize = true;
            интервал_перед_абзацемLabel.Location = new System.Drawing.Point(11, 31);
            интервал_перед_абзацемLabel.Name = "интервал_перед_абзацемLabel";
            интервал_перед_абзацемLabel.Size = new System.Drawing.Size(45, 15);
            интервал_перед_абзацемLabel.TabIndex = 2;
            интервал_перед_абзацемLabel.Text = "Перед:";
            // 
            // междустрочный_интервалLabel
            // 
            междустрочный_интервалLabel.AutoSize = true;
            междустрочный_интервалLabel.Location = new System.Drawing.Point(160, 29);
            междустрочный_интервалLabel.Name = "междустрочный_интервалLabel";
            междустрочный_интервалLabel.Size = new System.Drawing.Size(105, 30);
            междустрочный_интервалLabel.TabIndex = 5;
            междустрочный_интервалLabel.Text = "Междустрочный \r\nинтервал:";
            // 
            // размер_отступа_1_ой_строкиLabel
            // 
            размер_отступа_1_ой_строкиLabel.AutoSize = true;
            размер_отступа_1_ой_строкиLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            размер_отступа_1_ой_строкиLabel.Location = new System.Drawing.Point(146, 28);
            размер_отступа_1_ой_строкиLabel.Name = "размер_отступа_1_ой_строкиLabel";
            размер_отступа_1_ой_строкиLabel.Size = new System.Drawing.Size(179, 15);
            размер_отступа_1_ой_строкиLabel.TabIndex = 2;
            размер_отступа_1_ой_строкиLabel.Text = "Размер отступа первой строки:";
            // 
            // размер_отступа_справаLabel
            // 
            размер_отступа_справаLabel.AutoSize = true;
            размер_отступа_справаLabel.Location = new System.Drawing.Point(11, 61);
            размер_отступа_справаLabel.Name = "размер_отступа_справаLabel";
            размер_отступа_справаLabel.Size = new System.Drawing.Size(50, 15);
            размер_отступа_справаLabel.TabIndex = 4;
            размер_отступа_справаLabel.Text = "Справа:";
            // 
            // размер_отступа_слеваLabel
            // 
            размер_отступа_слеваLabel.AutoSize = true;
            размер_отступа_слеваLabel.Location = new System.Drawing.Point(11, 27);
            размер_отступа_слеваLabel.Name = "размер_отступа_слеваLabel";
            размер_отступа_слеваLabel.Size = new System.Drawing.Size(43, 15);
            размер_отступа_слеваLabel.TabIndex = 6;
            размер_отступа_слеваLabel.Text = "Слева:";
            // 
            // выравниваниеLabel
            // 
            выравниваниеLabel.AutoSize = true;
            выравниваниеLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            выравниваниеLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            выравниваниеLabel.ForeColor = System.Drawing.Color.White;
            выравниваниеLabel.Location = new System.Drawing.Point(21, 23);
            выравниваниеLabel.Name = "выравниваниеLabel";
            выравниваниеLabel.Size = new System.Drawing.Size(93, 15);
            выравниваниеLabel.TabIndex = 1;
            выравниваниеLabel.Text = "Выравнивание:";
            // 
            // gbInt
            // 
            this.gbInt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.gbInt.Controls.Add(интервал_после_абзацаLabel);
            this.gbInt.Controls.Add(this.numStrInt);
            this.gbInt.Controls.Add(this.numAfter);
            this.gbInt.Controls.Add(this.label7);
            this.gbInt.Controls.Add(this.label6);
            this.gbInt.Controls.Add(this.label5);
            this.gbInt.Controls.Add(интервал_перед_абзацемLabel);
            this.gbInt.Controls.Add(this.numBefore);
            this.gbInt.Controls.Add(междустрочный_интервалLabel);
            this.gbInt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbInt.ForeColor = System.Drawing.Color.White;
            this.gbInt.Location = new System.Drawing.Point(18, 148);
            this.gbInt.Name = "gbInt";
            this.gbInt.Size = new System.Drawing.Size(413, 97);
            this.gbInt.TabIndex = 7;
            this.gbInt.TabStop = false;
            this.gbInt.Text = "Интервал";
            // 
            // numStrInt
            // 
            this.numStrInt.DecimalPlaces = 1;
            this.numStrInt.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numStrInt.Location = new System.Drawing.Point(266, 29);
            this.numStrInt.Name = "numStrInt";
            this.numStrInt.Size = new System.Drawing.Size(55, 23);
            this.numStrInt.TabIndex = 1;
            this.numStrInt.ThousandsSeparator = true;
            this.numStrInt.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numAfter
            // 
            this.numAfter.Increment = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numAfter.Location = new System.Drawing.Point(64, 62);
            this.numAfter.Name = "numAfter";
            this.numAfter.Size = new System.Drawing.Size(43, 23);
            this.numAfter.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "пт";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "пт";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "пт";
            // 
            // numBefore
            // 
            this.numBefore.Increment = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numBefore.Location = new System.Drawing.Point(64, 27);
            this.numBefore.Name = "numBefore";
            this.numBefore.Size = new System.Drawing.Size(43, 23);
            this.numBefore.TabIndex = 3;
            // 
            // gbOtst
            // 
            this.gbOtst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.gbOtst.Controls.Add(this.numOtst);
            this.gbOtst.Controls.Add(this.label3);
            this.gbOtst.Controls.Add(this.label2);
            this.gbOtst.Controls.Add(this.label1);
            this.gbOtst.Controls.Add(размер_отступа_1_ой_строкиLabel);
            this.gbOtst.Controls.Add(размер_отступа_справаLabel);
            this.gbOtst.Controls.Add(this.numRight);
            this.gbOtst.Controls.Add(размер_отступа_слеваLabel);
            this.gbOtst.Controls.Add(this.numLeft);
            this.gbOtst.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbOtst.ForeColor = System.Drawing.Color.White;
            this.gbOtst.Location = new System.Drawing.Point(18, 49);
            this.gbOtst.Name = "gbOtst";
            this.gbOtst.Size = new System.Drawing.Size(413, 93);
            this.gbOtst.TabIndex = 8;
            this.gbOtst.TabStop = false;
            this.gbOtst.Text = "Отступ";
            // 
            // numOtst
            // 
            this.numOtst.DecimalPlaces = 2;
            this.numOtst.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numOtst.Location = new System.Drawing.Point(329, 25);
            this.numOtst.Name = "numOtst";
            this.numOtst.Size = new System.Drawing.Size(50, 23);
            this.numOtst.TabIndex = 1;
            this.numOtst.ThousandsSeparator = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "см";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "см";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "см";
            // 
            // numRight
            // 
            this.numRight.DecimalPlaces = 1;
            this.numRight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numRight.Location = new System.Drawing.Point(64, 59);
            this.numRight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numRight.Name = "numRight";
            this.numRight.Size = new System.Drawing.Size(43, 23);
            this.numRight.TabIndex = 5;
            this.numRight.ThousandsSeparator = true;
            // 
            // numLeft
            // 
            this.numLeft.DecimalPlaces = 1;
            this.numLeft.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numLeft.Location = new System.Drawing.Point(64, 25);
            this.numLeft.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numLeft.Name = "numLeft";
            this.numLeft.Size = new System.Drawing.Size(43, 23);
            this.numLeft.TabIndex = 7;
            this.numLeft.ThousandsSeparator = true;
            // 
            // cbAlign
            // 
            this.cbAlign.DataSource = this.alignmentBindingSource;
            this.cbAlign.DisplayMember = "alignment";
            this.cbAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlign.FormattingEnabled = true;
            this.cbAlign.Location = new System.Drawing.Point(120, 21);
            this.cbAlign.Name = "cbAlign";
            this.cbAlign.Size = new System.Drawing.Size(150, 21);
            this.cbAlign.TabIndex = 0;
            this.cbAlign.ValueMember = "align_id";
            // 
            // alignmentBindingSource
            // 
            this.alignmentBindingSource.DataMember = "Alignment";
            this.alignmentBindingSource.DataSource = this.formatting_rules_DBDataSet;
            // 
            // formatting_rules_DBDataSet
            // 
            this.formatting_rules_DBDataSet.DataSetName = "formatting_rules_DBDataSet";
            this.formatting_rules_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(196)))), ((int)(((byte)(234)))));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(114, 255);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(183, 27);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // alignmentTableAdapter
            // 
            this.alignmentTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(12, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(425, 237);
            this.pictureBox7.TabIndex = 94;
            this.pictureBox7.TabStop = false;
            // 
            // frmEditPar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 289);
            this.Controls.Add(this.gbOtst);
            this.Controls.Add(this.cbAlign);
            this.Controls.Add(выравниваниеLabel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbInt);
            this.Controls.Add(this.pictureBox7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEditPar";
            this.Text = "Добавить/изменить абзац";
            this.Load += new System.EventHandler(this.frmEditPar_Load);
            this.gbInt.ResumeLayout(false);
            this.gbInt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStrInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBefore)).EndInit();
            this.gbOtst.ResumeLayout(false);
            this.gbOtst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOtst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formatting_rules_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInt;
        private System.Windows.Forms.NumericUpDown numStrInt;
        private System.Windows.Forms.NumericUpDown numAfter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numBefore;
        private System.Windows.Forms.GroupBox gbOtst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numRight;
        private System.Windows.Forms.NumericUpDown numLeft;
        private System.Windows.Forms.ComboBox cbAlign;
        private System.Windows.Forms.Button btnSave;
        private formatting_rules_DBDataSet formatting_rules_DBDataSet;
        private System.Windows.Forms.BindingSource alignmentBindingSource;
        private formatting_rules_DBDataSetTableAdapters.AlignmentTableAdapter alignmentTableAdapter;
        private System.Windows.Forms.NumericUpDown numOtst;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}