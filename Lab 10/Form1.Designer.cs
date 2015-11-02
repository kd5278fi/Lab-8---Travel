namespace Lab_10
{
    partial class Main
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
            this.btnMap = new System.Windows.Forms.Button();
            this.dateTimePickerDeparture = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerReturnDate = new System.Windows.Forms.DateTimePicker();
            this.listBoxTripDatesOrData = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.buttonGasCalc = new System.Windows.Forms.Button();
            this.btnEnterDates = new System.Windows.Forms.Button();
            this.btnForecast = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbForecastDay3 = new System.Windows.Forms.PictureBox();
            this.pbForecastDay2 = new System.Windows.Forms.PictureBox();
            this.pbForecastDay1 = new System.Windows.Forms.PictureBox();
            this.labelDescriptionDay1 = new System.Windows.Forms.Label();
            this.labelDescriptionDay2 = new System.Windows.Forms.Label();
            this.labelDescriptionDay3 = new System.Windows.Forms.Label();
            this.labelHighLowDay1 = new System.Windows.Forms.Label();
            this.labelHighLowDay2 = new System.Windows.Forms.Label();
            this.labelHighLowDay3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbForecastDay3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForecastDay2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForecastDay1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMap
            // 
            this.btnMap.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMap.Location = new System.Drawing.Point(122, 43);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(75, 23);
            this.btnMap.TabIndex = 0;
            this.btnMap.Text = "Map";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // dateTimePickerDeparture
            // 
            this.dateTimePickerDeparture.Location = new System.Drawing.Point(38, 177);
            this.dateTimePickerDeparture.Name = "dateTimePickerDeparture";
            this.dateTimePickerDeparture.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDeparture.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pick your route";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(547, 318);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Departure Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Return Date";
            // 
            // dateTimePickerReturnDate
            // 
            this.dateTimePickerReturnDate.Location = new System.Drawing.Point(292, 177);
            this.dateTimePickerReturnDate.Name = "dateTimePickerReturnDate";
            this.dateTimePickerReturnDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerReturnDate.TabIndex = 6;
            // 
            // listBoxTripDatesOrData
            // 
            this.listBoxTripDatesOrData.FormattingEnabled = true;
            this.listBoxTripDatesOrData.Location = new System.Drawing.Point(168, 206);
            this.listBoxTripDatesOrData.Name = "listBoxTripDatesOrData";
            this.listBoxTripDatesOrData.Size = new System.Drawing.Size(305, 95);
            this.listBoxTripDatesOrData.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Planned Trip Dates:";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(12, 278);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "&Esc";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // buttonGasCalc
            // 
            this.buttonGasCalc.Location = new System.Drawing.Point(547, 127);
            this.buttonGasCalc.Name = "buttonGasCalc";
            this.buttonGasCalc.Size = new System.Drawing.Size(68, 54);
            this.buttonGasCalc.TabIndex = 11;
            this.buttonGasCalc.Text = "&Gas Calculator";
            this.buttonGasCalc.UseVisualStyleBackColor = true;
            this.buttonGasCalc.Click += new System.EventHandler(this.buttonGasCalc_Click);
            // 
            // btnEnterDates
            // 
            this.btnEnterDates.Location = new System.Drawing.Point(491, 215);
            this.btnEnterDates.Name = "btnEnterDates";
            this.btnEnterDates.Size = new System.Drawing.Size(106, 32);
            this.btnEnterDates.TabIndex = 9;
            this.btnEnterDates.Text = "Enter Dates";
            this.btnEnterDates.UseVisualStyleBackColor = true;
            this.btnEnterDates.Click += new System.EventHandler(this.btnEnterDates_Click);
            // 
            // btnForecast
            // 
            this.btnForecast.Location = new System.Drawing.Point(154, 88);
            this.btnForecast.Name = "btnForecast";
            this.btnForecast.Size = new System.Drawing.Size(75, 23);
            this.btnForecast.TabIndex = 12;
            this.btnForecast.Text = "Forecast";
            this.btnForecast.UseVisualStyleBackColor = true;
            this.btnForecast.Click += new System.EventHandler(this.btnForecast_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Get the Fake Forcast ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbForecastDay3);
            this.panel1.Controls.Add(this.pbForecastDay2);
            this.panel1.Controls.Add(this.pbForecastDay1);
            this.panel1.Location = new System.Drawing.Point(245, 21);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(16);
            this.panel1.Size = new System.Drawing.Size(317, 100);
            this.panel1.TabIndex = 14;
            // 
            // pbForecastDay3
            // 
            this.pbForecastDay3.Location = new System.Drawing.Point(213, 2);
            this.pbForecastDay3.Name = "pbForecastDay3";
            this.pbForecastDay3.Size = new System.Drawing.Size(104, 97);
            this.pbForecastDay3.TabIndex = 2;
            this.pbForecastDay3.TabStop = false;
            // 
            // pbForecastDay2
            // 
            this.pbForecastDay2.Location = new System.Drawing.Point(109, 2);
            this.pbForecastDay2.Name = "pbForecastDay2";
            this.pbForecastDay2.Size = new System.Drawing.Size(104, 97);
            this.pbForecastDay2.TabIndex = 1;
            this.pbForecastDay2.TabStop = false;
            // 
            // pbForecastDay1
            // 
            this.pbForecastDay1.Location = new System.Drawing.Point(5, 3);
            this.pbForecastDay1.Name = "pbForecastDay1";
            this.pbForecastDay1.Size = new System.Drawing.Size(104, 97);
            this.pbForecastDay1.TabIndex = 0;
            this.pbForecastDay1.TabStop = false;
            // 
            // labelDescriptionDay1
            // 
            this.labelDescriptionDay1.AutoSize = true;
            this.labelDescriptionDay1.Location = new System.Drawing.Point(242, 0);
            this.labelDescriptionDay1.Name = "labelDescriptionDay1";
            this.labelDescriptionDay1.Size = new System.Drawing.Size(0, 13);
            this.labelDescriptionDay1.TabIndex = 15;
            // 
            // labelDescriptionDay2
            // 
            this.labelDescriptionDay2.AutoSize = true;
            this.labelDescriptionDay2.Location = new System.Drawing.Point(364, 0);
            this.labelDescriptionDay2.Name = "labelDescriptionDay2";
            this.labelDescriptionDay2.Size = new System.Drawing.Size(0, 13);
            this.labelDescriptionDay2.TabIndex = 16;
            // 
            // labelDescriptionDay3
            // 
            this.labelDescriptionDay3.AutoSize = true;
            this.labelDescriptionDay3.Location = new System.Drawing.Point(457, 0);
            this.labelDescriptionDay3.Name = "labelDescriptionDay3";
            this.labelDescriptionDay3.Size = new System.Drawing.Size(0, 13);
            this.labelDescriptionDay3.TabIndex = 17;
            // 
            // labelHighLowDay1
            // 
            this.labelHighLowDay1.AutoSize = true;
            this.labelHighLowDay1.Location = new System.Drawing.Point(262, 127);
            this.labelHighLowDay1.Name = "labelHighLowDay1";
            this.labelHighLowDay1.Size = new System.Drawing.Size(0, 13);
            this.labelHighLowDay1.TabIndex = 18;
            // 
            // labelHighLowDay2
            // 
            this.labelHighLowDay2.AutoSize = true;
            this.labelHighLowDay2.Location = new System.Drawing.Point(364, 127);
            this.labelHighLowDay2.Name = "labelHighLowDay2";
            this.labelHighLowDay2.Size = new System.Drawing.Size(0, 13);
            this.labelHighLowDay2.TabIndex = 19;
            // 
            // labelHighLowDay3
            // 
            this.labelHighLowDay3.AutoSize = true;
            this.labelHighLowDay3.Location = new System.Drawing.Point(466, 127);
            this.labelHighLowDay3.Name = "labelHighLowDay3";
            this.labelHighLowDay3.Size = new System.Drawing.Size(0, 13);
            this.labelHighLowDay3.TabIndex = 20;
            // 
            // Main
            // 
            this.AcceptButton = this.btnEnterDates;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(649, 339);
            this.Controls.Add(this.labelHighLowDay3);
            this.Controls.Add(this.labelHighLowDay2);
            this.Controls.Add(this.labelHighLowDay1);
            this.Controls.Add(this.labelDescriptionDay3);
            this.Controls.Add(this.labelDescriptionDay2);
            this.Controls.Add(this.labelDescriptionDay1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnForecast);
            this.Controls.Add(this.btnEnterDates);
            this.Controls.Add(this.buttonGasCalc);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxTripDatesOrData);
            this.Controls.Add(this.dateTimePickerReturnDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDeparture);
            this.Controls.Add(this.btnMap);
            this.Name = "Main";
            this.Text = "Travel App";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbForecastDay3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForecastDay2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForecastDay1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeparture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturnDate;
        private System.Windows.Forms.ListBox listBoxTripDatesOrData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button buttonGasCalc;
        private System.Windows.Forms.Button btnEnterDates;
        private System.Windows.Forms.Button btnForecast;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbForecastDay3;
        private System.Windows.Forms.PictureBox pbForecastDay2;
        private System.Windows.Forms.PictureBox pbForecastDay1;
        private System.Windows.Forms.Label labelDescriptionDay1;
        private System.Windows.Forms.Label labelDescriptionDay2;
        private System.Windows.Forms.Label labelDescriptionDay3;
        private System.Windows.Forms.Label labelHighLowDay1;
        private System.Windows.Forms.Label labelHighLowDay2;
        private System.Windows.Forms.Label labelHighLowDay3;

    }
}

