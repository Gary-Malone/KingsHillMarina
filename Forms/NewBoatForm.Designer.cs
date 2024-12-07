namespace KingsHillMarina
{
    partial class NewBoatForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoatName = new System.Windows.Forms.TextBox();
            this.txtBoatMake = new System.Windows.Forms.TextBox();
            this.txtBoatType = new System.Windows.Forms.TextBox();
            this.cmbOwner = new System.Windows.Forms.ComboBox();
            this.dtpDockedAt = new System.Windows.Forms.DateTimePicker();
            this.cmbPier = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boat name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Boat make";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Boat type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Owner";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date docked";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pier";
            // 
            // txtBoatName
            // 
            this.txtBoatName.Location = new System.Drawing.Point(182, 63);
            this.txtBoatName.Name = "txtBoatName";
            this.txtBoatName.Size = new System.Drawing.Size(100, 20);
            this.txtBoatName.TabIndex = 6;
            // 
            // txtBoatMake
            // 
            this.txtBoatMake.Location = new System.Drawing.Point(182, 103);
            this.txtBoatMake.Name = "txtBoatMake";
            this.txtBoatMake.Size = new System.Drawing.Size(100, 20);
            this.txtBoatMake.TabIndex = 7;
            // 
            // txtBoatType
            // 
            this.txtBoatType.Location = new System.Drawing.Point(182, 136);
            this.txtBoatType.Name = "txtBoatType";
            this.txtBoatType.Size = new System.Drawing.Size(100, 20);
            this.txtBoatType.TabIndex = 8;
            // 
            // cmbOwner
            // 
            this.cmbOwner.FormattingEnabled = true;
            this.cmbOwner.Location = new System.Drawing.Point(182, 171);
            this.cmbOwner.Name = "cmbOwner";
            this.cmbOwner.Size = new System.Drawing.Size(121, 21);
            this.cmbOwner.TabIndex = 9;
            // 
            // dtpDockedAt
            // 
            this.dtpDockedAt.Location = new System.Drawing.Point(182, 247);
            this.dtpDockedAt.Name = "dtpDockedAt";
            this.dtpDockedAt.Size = new System.Drawing.Size(200, 20);
            this.dtpDockedAt.TabIndex = 10;
            // 
            // cmbPier
            // 
            this.cmbPier.FormattingEnabled = true;
            this.cmbPier.Location = new System.Drawing.Point(182, 207);
            this.cmbPier.Name = "cmbPier";
            this.cmbPier.Size = new System.Drawing.Size(121, 21);
            this.cmbPier.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(170, 299);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // NewBoatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 342);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbPier);
            this.Controls.Add(this.dtpDockedAt);
            this.Controls.Add(this.cmbOwner);
            this.Controls.Add(this.txtBoatType);
            this.Controls.Add(this.txtBoatMake);
            this.Controls.Add(this.txtBoatName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewBoatForm";
            this.Text = "New boat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoatName;
        private System.Windows.Forms.TextBox txtBoatMake;
        private System.Windows.Forms.TextBox txtBoatType;
        private System.Windows.Forms.ComboBox cmbOwner;
        private System.Windows.Forms.DateTimePicker dtpDockedAt;
        private System.Windows.Forms.ComboBox cmbPier;
        private System.Windows.Forms.Button btnSave;
    }
}