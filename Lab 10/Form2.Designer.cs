namespace Lab_10
{
    partial class Form2Map
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
            this.pictureBoxUnitestStatesRegions = new System.Windows.Forms.PictureBox();
            this.checkBoxWest = new System.Windows.Forms.CheckBox();
            this.checkBoxMidWest = new System.Windows.Forms.CheckBox();
            this.checkBoxSouthWest = new System.Windows.Forms.CheckBox();
            this.checkBoxSouthEast = new System.Windows.Forms.CheckBox();
            this.checkBoxNorthEast = new System.Windows.Forms.CheckBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnitestStatesRegions)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxUnitestStatesRegions
            // 
            this.pictureBoxUnitestStatesRegions.Image = global::Lab_10.Properties.Resources.regionsOfUsPic;
            this.pictureBoxUnitestStatesRegions.InitialImage = global::Lab_10.Properties.Resources.regionsOfUsPic;
            this.pictureBoxUnitestStatesRegions.Location = new System.Drawing.Point(-10, 32);
            this.pictureBoxUnitestStatesRegions.Name = "pictureBoxUnitestStatesRegions";
            this.pictureBoxUnitestStatesRegions.Size = new System.Drawing.Size(408, 309);
            this.pictureBoxUnitestStatesRegions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUnitestStatesRegions.TabIndex = 0;
            this.pictureBoxUnitestStatesRegions.TabStop = false;
            // 
            // checkBoxWest
            // 
            this.checkBoxWest.AutoSize = true;
            this.checkBoxWest.Location = new System.Drawing.Point(55, 130);
            this.checkBoxWest.Name = "checkBoxWest";
            this.checkBoxWest.Size = new System.Drawing.Size(15, 14);
            this.checkBoxWest.TabIndex = 1;
            this.checkBoxWest.UseVisualStyleBackColor = true;
            this.checkBoxWest.CheckedChanged += new System.EventHandler(this.checkBoxWest_CheckedChanged);
            // 
            // checkBoxMidWest
            // 
            this.checkBoxMidWest.AutoSize = true;
            this.checkBoxMidWest.Location = new System.Drawing.Point(216, 119);
            this.checkBoxMidWest.Name = "checkBoxMidWest";
            this.checkBoxMidWest.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMidWest.TabIndex = 2;
            this.checkBoxMidWest.UseVisualStyleBackColor = true;
            this.checkBoxMidWest.CheckedChanged += new System.EventHandler(this.checkBoxMidWest_CheckedChanged);
            // 
            // checkBoxSouthWest
            // 
            this.checkBoxSouthWest.AutoSize = true;
            this.checkBoxSouthWest.Location = new System.Drawing.Point(103, 218);
            this.checkBoxSouthWest.Name = "checkBoxSouthWest";
            this.checkBoxSouthWest.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSouthWest.TabIndex = 3;
            this.checkBoxSouthWest.UseVisualStyleBackColor = true;
            this.checkBoxSouthWest.CheckedChanged += new System.EventHandler(this.checkBoxSouthWest_CheckedChanged);
            // 
            // checkBoxSouthEast
            // 
            this.checkBoxSouthEast.AutoSize = true;
            this.checkBoxSouthEast.Location = new System.Drawing.Point(278, 197);
            this.checkBoxSouthEast.Name = "checkBoxSouthEast";
            this.checkBoxSouthEast.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSouthEast.TabIndex = 4;
            this.checkBoxSouthEast.UseVisualStyleBackColor = true;
            this.checkBoxSouthEast.CheckedChanged += new System.EventHandler(this.checkBoxSouthEast_CheckedChanged);
            // 
            // checkBoxNorthEast
            // 
            this.checkBoxNorthEast.AutoSize = true;
            this.checkBoxNorthEast.Location = new System.Drawing.Point(335, 149);
            this.checkBoxNorthEast.Name = "checkBoxNorthEast";
            this.checkBoxNorthEast.Size = new System.Drawing.Size(15, 14);
            this.checkBoxNorthEast.TabIndex = 5;
            this.checkBoxNorthEast.UseVisualStyleBackColor = true;
            this.checkBoxNorthEast.CheckedChanged += new System.EventHandler(this.checkBoxNorthEast_CheckedChanged);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(32, 343);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 7;
            this.buttonConfirm.Text = "&Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGoBack.Location = new System.Drawing.Point(295, 343);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnGoBack.TabIndex = 8;
            this.btnGoBack.Text = "Go &Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Click the boxes for the regions you\'ll be traveling to";
            // 
            // Form2Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnGoBack;
            this.ClientSize = new System.Drawing.Size(410, 389);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxSouthEast);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.checkBoxMidWest);
            this.Controls.Add(this.checkBoxNorthEast);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.checkBoxWest);
            this.Controls.Add(this.checkBoxSouthWest);
            this.Controls.Add(this.pictureBoxUnitestStatesRegions);
            this.Enabled = false;
            this.Name = "Form2Map";
            this.Text = "Map ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnitestStatesRegions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxUnitestStatesRegions;
        private System.Windows.Forms.CheckBox checkBoxWest;
        private System.Windows.Forms.CheckBox checkBoxMidWest;
        private System.Windows.Forms.CheckBox checkBoxSouthWest;
        private System.Windows.Forms.CheckBox checkBoxSouthEast;
        private System.Windows.Forms.CheckBox checkBoxNorthEast;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label label1;
    }
}