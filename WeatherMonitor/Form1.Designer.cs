namespace WeatherMonitor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxCity = new TextBox();
            buttonSearch = new Button();
            comboBoxCapitals = new ComboBox();
            labelTemp = new Label();
            labelPressure = new Label();
            labelHumidity = new Label();
            pictureBoxIcon = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            SuspendLayout();
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(45, 83);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(150, 31);
            textBoxCity.TabIndex = 0;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(45, 259);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(112, 34);
            buttonSearch.TabIndex = 1;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // comboBoxCapitals
            // 
            comboBoxCapitals.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCapitals.FormattingEnabled = true;
            comboBoxCapitals.Location = new Point(45, 188);
            comboBoxCapitals.Name = "comboBoxCapitals";
            comboBoxCapitals.Size = new Size(182, 33);
            comboBoxCapitals.TabIndex = 2;
            // 
            // labelTemp
            // 
            labelTemp.AutoSize = true;
            labelTemp.Location = new Point(562, 122);
            labelTemp.Name = "labelTemp";
            labelTemp.Size = new Size(19, 25);
            labelTemp.TabIndex = 3;
            labelTemp.Text = "-";
            // 
            // labelPressure
            // 
            labelPressure.AutoSize = true;
            labelPressure.Location = new Point(562, 167);
            labelPressure.Name = "labelPressure";
            labelPressure.Size = new Size(19, 25);
            labelPressure.TabIndex = 4;
            labelPressure.Text = "-";
            // 
            // labelHumidity
            // 
            labelHumidity.AutoSize = true;
            labelHumidity.Location = new Point(562, 222);
            labelHumidity.Name = "labelHumidity";
            labelHumidity.Size = new Size(19, 25);
            labelHumidity.TabIndex = 5;
            labelHumidity.Text = "-";
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Location = new Point(895, 113);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(196, 170);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIcon.TabIndex = 6;
            pictureBoxIcon.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(431, 122);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 7;
            label1.Text = "Temperature: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(433, 167);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 8;
            label2.Text = "Pressure:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(433, 222);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 9;
            label3.Text = "Humidity:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 44);
            label4.Name = "label4";
            label4.Size = new Size(118, 25);
            label4.TabIndex = 10;
            label4.Text = "Enter the city:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 146);
            label5.Name = "label5";
            label5.Size = new Size(279, 25);
            label5.TabIndex = 11;
            label5.Text = "or choose from the popular ones:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 640);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBoxIcon);
            Controls.Add(labelHumidity);
            Controls.Add(labelPressure);
            Controls.Add(labelTemp);
            Controls.Add(comboBoxCapitals);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxCity);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCity;
        private Button buttonSearch;
        private ComboBox comboBoxCapitals;
        private Label labelTemp;
        private Label labelPressure;
        private Label labelHumidity;
        private PictureBox pictureBoxIcon;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
