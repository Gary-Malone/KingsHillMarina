namespace KingsHillMarina
{
    partial class homeForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.btnAddOwner = new System.Windows.Forms.Button();
            this.btnAddBoat = new System.Windows.Forms.Button();
            this.btnViewPiers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(138, 74);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(318, 46);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Kings Hill Marina";
            // 
            // btnAddOwner
            // 
            this.btnAddOwner.Location = new System.Drawing.Point(116, 226);
            this.btnAddOwner.Name = "btnAddOwner";
            this.btnAddOwner.Size = new System.Drawing.Size(114, 39);
            this.btnAddOwner.TabIndex = 1;
            this.btnAddOwner.Text = "Add owner";
            this.btnAddOwner.UseVisualStyleBackColor = true;
            this.btnAddOwner.Click += new System.EventHandler(this.btnAddOwner_Click);
            // 
            // btnAddBoat
            // 
            this.btnAddBoat.Location = new System.Drawing.Point(266, 226);
            this.btnAddBoat.Name = "btnAddBoat";
            this.btnAddBoat.Size = new System.Drawing.Size(114, 39);
            this.btnAddBoat.TabIndex = 2;
            this.btnAddBoat.Text = "Add boat";
            this.btnAddBoat.UseVisualStyleBackColor = true;
            this.btnAddBoat.Click += new System.EventHandler(this.btnAddBoat_Click);
            // 
            // btnViewPiers
            // 
            this.btnViewPiers.Location = new System.Drawing.Point(412, 226);
            this.btnViewPiers.Name = "btnViewPiers";
            this.btnViewPiers.Size = new System.Drawing.Size(112, 39);
            this.btnViewPiers.TabIndex = 3;
            this.btnViewPiers.Text = "View piers";
            this.btnViewPiers.UseVisualStyleBackColor = true;
            this.btnViewPiers.Click += new System.EventHandler(this.btnViewPiers_Click);
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 355);
            this.Controls.Add(this.btnViewPiers);
            this.Controls.Add(this.btnAddBoat);
            this.Controls.Add(this.btnAddOwner);
            this.Controls.Add(this.titleLabel);
            this.Name = "homeForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.homeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button btnAddOwner;
        private System.Windows.Forms.Button btnAddBoat;
        private System.Windows.Forms.Button btnViewPiers;
    }
}

