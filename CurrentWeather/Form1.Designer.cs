namespace CurrentWeather
{
    partial class Form1
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
            this.picWeather = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWeather = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnGetWeather = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbxState = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWeather)).BeginInit();
            this.SuspendLayout();
            // 
            // picWeather
            // 
            this.picWeather.Location = new System.Drawing.Point(38, 64);
            this.picWeather.Name = "picWeather";
            this.picWeather.Size = new System.Drawing.Size(478, 220);
            this.picWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWeather.TabIndex = 0;
            this.picWeather.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "State:";
            // 
            // lblWeather
            // 
            this.lblWeather.Location = new System.Drawing.Point(103, 76);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(346, 81);
            this.lblWeather.TabIndex = 3;
            this.lblWeather.Text = "Enter city and state to get weather";
            this.lblWeather.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(68, 22);
            this.txtCity.MaxLength = 50;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(166, 20);
            this.txtCity.TabIndex = 4;
            // 
            // btnGetWeather
            // 
            this.btnGetWeather.Location = new System.Drawing.Point(416, 20);
            this.btnGetWeather.Name = "btnGetWeather";
            this.btnGetWeather.Size = new System.Drawing.Size(100, 23);
            this.btnGetWeather.TabIndex = 6;
            this.btnGetWeather.Text = "Get &Weather";
            this.btnGetWeather.UseVisualStyleBackColor = true;
            this.btnGetWeather.Click += new System.EventHandler(this.btnGetWeather_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(385, 299);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbxState
            // 
            this.cbxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxState.DropDownWidth = 45;
            this.cbxState.FormattingEnabled = true;
            this.cbxState.Location = new System.Drawing.Point(307, 22);
            this.cbxState.Name = "cbxState";
            this.cbxState.Size = new System.Drawing.Size(45, 21);
            this.cbxState.Sorted = true;
            this.cbxState.TabIndex = 5;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGetWeather;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(555, 334);
            this.Controls.Add(this.cbxState);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGetWeather);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblWeather);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picWeather);
            this.Name = "Form1";
            this.Text = "Current Weather";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWeather)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picWeather;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWeather;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnGetWeather;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbxState;
    }
}

