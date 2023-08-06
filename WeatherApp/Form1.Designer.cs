namespace WeatherApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.TBCity = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.LabCondition = new System.Windows.Forms.Label();
            this.LabDetails = new System.Windows.Forms.Label();
            this.Sunrise = new System.Windows.Forms.Label();
            this.Sunset = new System.Windows.Forms.Label();
            this.Windspeed = new System.Windows.Forms.Label();
            this.Pressure = new System.Windows.Forms.Label();
            this.LabSunrise = new System.Windows.Forms.Label();
            this.LabSunset = new System.Windows.Forms.Label();
            this.LabWindspeed = new System.Windows.Forms.Label();
            this.LabPressure = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.LabTemp = new System.Windows.Forms.Label();
            this.Temp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(574, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "City";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBCity
            // 
            this.TBCity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCity.Location = new System.Drawing.Point(700, 284);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(343, 31);
            this.TBCity.TabIndex = 1;
            this.TBCity.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1071, 284);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(126, 31);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // LabCondition
            // 
            this.LabCondition.AutoSize = true;
            this.LabCondition.BackColor = System.Drawing.Color.Transparent;
            this.LabCondition.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCondition.Location = new System.Drawing.Point(574, 442);
            this.LabCondition.Name = "LabCondition";
            this.LabCondition.Size = new System.Drawing.Size(204, 42);
            this.LabCondition.TabIndex = 3;
            this.LabCondition.Text = "Condition";
            // 
            // LabDetails
            // 
            this.LabDetails.AutoSize = true;
            this.LabDetails.BackColor = System.Drawing.Color.Transparent;
            this.LabDetails.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDetails.Location = new System.Drawing.Point(574, 531);
            this.LabDetails.Name = "LabDetails";
            this.LabDetails.Size = new System.Drawing.Size(148, 42);
            this.LabDetails.TabIndex = 4;
            this.LabDetails.Text = "Details";
            this.LabDetails.Click += new System.EventHandler(this.label3_Click);
            // 
            // Sunrise
            // 
            this.Sunrise.AutoSize = true;
            this.Sunrise.BackColor = System.Drawing.Color.Transparent;
            this.Sunrise.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sunrise.Location = new System.Drawing.Point(574, 610);
            this.Sunrise.Name = "Sunrise";
            this.Sunrise.Size = new System.Drawing.Size(162, 42);
            this.Sunrise.TabIndex = 5;
            this.Sunrise.Text = "Sunrise";
            this.Sunrise.Click += new System.EventHandler(this.label4_Click);
            // 
            // Sunset
            // 
            this.Sunset.AutoSize = true;
            this.Sunset.BackColor = System.Drawing.Color.Transparent;
            this.Sunset.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sunset.Location = new System.Drawing.Point(574, 686);
            this.Sunset.Name = "Sunset";
            this.Sunset.Size = new System.Drawing.Size(147, 42);
            this.Sunset.TabIndex = 7;
            this.Sunset.Text = "Sunset";
            // 
            // Windspeed
            // 
            this.Windspeed.AutoSize = true;
            this.Windspeed.BackColor = System.Drawing.Color.Transparent;
            this.Windspeed.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Windspeed.Location = new System.Drawing.Point(1064, 516);
            this.Windspeed.Name = "Windspeed";
            this.Windspeed.Size = new System.Drawing.Size(233, 42);
            this.Windspeed.TabIndex = 8;
            this.Windspeed.Text = "Wind speed";
            this.Windspeed.Click += new System.EventHandler(this.label5_Click);
            // 
            // Pressure
            // 
            this.Pressure.AutoSize = true;
            this.Pressure.BackColor = System.Drawing.Color.Transparent;
            this.Pressure.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pressure.Location = new System.Drawing.Point(1064, 607);
            this.Pressure.Name = "Pressure";
            this.Pressure.Size = new System.Drawing.Size(184, 42);
            this.Pressure.TabIndex = 9;
            this.Pressure.Text = "Pressure";
            // 
            // LabSunrise
            // 
            this.LabSunrise.AutoSize = true;
            this.LabSunrise.BackColor = System.Drawing.Color.Transparent;
            this.LabSunrise.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSunrise.Location = new System.Drawing.Point(742, 622);
            this.LabSunrise.Name = "LabSunrise";
            this.LabSunrise.Size = new System.Drawing.Size(0, 27);
            this.LabSunrise.TabIndex = 10;
            // 
            // LabSunset
            // 
            this.LabSunset.AutoSize = true;
            this.LabSunset.BackColor = System.Drawing.Color.Transparent;
            this.LabSunset.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSunset.Location = new System.Drawing.Point(742, 698);
            this.LabSunset.Name = "LabSunset";
            this.LabSunset.Size = new System.Drawing.Size(0, 27);
            this.LabSunset.TabIndex = 11;
            this.LabSunset.Click += new System.EventHandler(this.LabSunset_Click);
            // 
            // LabWindspeed
            // 
            this.LabWindspeed.AutoSize = true;
            this.LabWindspeed.BackColor = System.Drawing.Color.Transparent;
            this.LabWindspeed.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabWindspeed.Location = new System.Drawing.Point(1320, 531);
            this.LabWindspeed.Name = "LabWindspeed";
            this.LabWindspeed.Size = new System.Drawing.Size(0, 27);
            this.LabWindspeed.TabIndex = 12;
            // 
            // LabPressure
            // 
            this.LabPressure.AutoSize = true;
            this.LabPressure.BackColor = System.Drawing.Color.Transparent;
            this.LabPressure.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabPressure.Location = new System.Drawing.Point(1320, 622);
            this.LabPressure.Name = "LabPressure";
            this.LabPressure.Size = new System.Drawing.Size(0, 27);
            this.LabPressure.TabIndex = 13;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Location = new System.Drawing.Point(581, 362);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(79, 52);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LabTemp
            // 
            this.LabTemp.AutoSize = true;
            this.LabTemp.BackColor = System.Drawing.Color.Transparent;
            this.LabTemp.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTemp.Location = new System.Drawing.Point(1310, 454);
            this.LabTemp.Name = "LabTemp";
            this.LabTemp.Size = new System.Drawing.Size(0, 27);
            this.LabTemp.TabIndex = 15;
            // 
            // Temp
            // 
            this.Temp.AutoSize = true;
            this.Temp.BackColor = System.Drawing.Color.Transparent;
            this.Temp.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temp.Location = new System.Drawing.Point(1064, 442);
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(125, 42);
            this.Temp.TabIndex = 16;
            this.Temp.Text = "Temp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1379, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 27);
            this.label2.TabIndex = 17;
            this.label2.Text = "°C";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1757, 1091);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Temp);
            this.Controls.Add(this.LabTemp);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.LabPressure);
            this.Controls.Add(this.LabWindspeed);
            this.Controls.Add(this.LabSunset);
            this.Controls.Add(this.LabSunrise);
            this.Controls.Add(this.Pressure);
            this.Controls.Add(this.Windspeed);
            this.Controls.Add(this.Sunset);
            this.Controls.Add(this.Sunrise);
            this.Controls.Add(this.LabDetails);
            this.Controls.Add(this.LabCondition);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.TBCity);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label LabCondition;
        private System.Windows.Forms.Label LabDetails;
        private System.Windows.Forms.Label Sunrise;
        private System.Windows.Forms.Label Sunset;
        private System.Windows.Forms.Label Windspeed;
        private System.Windows.Forms.Label Pressure;
        private System.Windows.Forms.Label LabSunrise;
        private System.Windows.Forms.Label LabSunset;
        private System.Windows.Forms.Label LabWindspeed;
        private System.Windows.Forms.Label LabPressure;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label LabTemp;
        private System.Windows.Forms.Label Temp;
        private System.Windows.Forms.Label label2;
    }
}

