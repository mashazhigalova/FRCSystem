namespace FRC_System
{
    partial class frmEditNum
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
            System.Windows.Forms.Label положение_на_страницеLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditNum));
            this.formatting_rules_DBDataSet = new FRC_System.formatting_rules_DBDataSet();
            this.cbPlace = new System.Windows.Forms.ComboBox();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.locationTableAdapter = new FRC_System.formatting_rules_DBDataSetTableAdapters.LocationTableAdapter();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            положение_на_страницеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.formatting_rules_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // положение_на_страницеLabel
            // 
            положение_на_страницеLabel.AutoSize = true;
            положение_на_страницеLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            положение_на_страницеLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            положение_на_страницеLabel.ForeColor = System.Drawing.Color.White;
            положение_на_страницеLabel.Location = new System.Drawing.Point(10, 26);
            положение_на_страницеLabel.Name = "положение_на_страницеLabel";
            положение_на_страницеLabel.Size = new System.Drawing.Size(145, 15);
            положение_на_страницеLabel.TabIndex = 17;
            положение_на_страницеLabel.Text = "Положение на странице:";
            // 
            // formatting_rules_DBDataSet
            // 
            this.formatting_rules_DBDataSet.DataSetName = "formatting_rules_DBDataSet";
            this.formatting_rules_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbPlace
            // 
            this.cbPlace.DataSource = this.locationBindingSource;
            this.cbPlace.DisplayMember = "location";
            this.cbPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlace.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPlace.FormattingEnabled = true;
            this.cbPlace.Location = new System.Drawing.Point(161, 23);
            this.cbPlace.Name = "cbPlace";
            this.cbPlace.Size = new System.Drawing.Size(158, 23);
            this.cbPlace.TabIndex = 15;
            this.cbPlace.ValueMember = "location_id";
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataMember = "Location";
            this.locationBindingSource.DataSource = this.formatting_rules_DBDataSet;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(196)))), ((int)(((byte)(234)))));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(65, 74);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(183, 27);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // locationTableAdapter
            // 
            this.locationTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(8, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(317, 56);
            this.pictureBox7.TabIndex = 94;
            this.pictureBox7.TabStop = false;
            // 
            // frmEditNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 111);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(положение_на_страницеLabel);
            this.Controls.Add(this.cbPlace);
            this.Controls.Add(this.pictureBox7);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEditNum";
            this.Text = "Добавить/изменить нумерацию";
            this.Load += new System.EventHandler(this.frmEditNum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.formatting_rules_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPlace;
        private System.Windows.Forms.Button btnSave;
        private formatting_rules_DBDataSet formatting_rules_DBDataSet;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private formatting_rules_DBDataSetTableAdapters.LocationTableAdapter locationTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}