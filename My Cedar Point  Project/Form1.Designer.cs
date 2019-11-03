using System.Drawing;

namespace WindowsFormsApplication1
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
            this.lblName = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lblSeason = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtSeason = new System.Windows.Forms.TextBox();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.picAmusementPark = new System.Windows.Forms.PictureBox();
            this.picSki = new System.Windows.Forms.PictureBox();
            this.picClosed = new System.Windows.Forms.PictureBox();
            this.picWaterPark = new System.Windows.Forms.PictureBox();
            this.btnRecommend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picStormLand = new System.Windows.Forms.PictureBox();
            this.lblRide = new System.Windows.Forms.Label();
            this.lblPark = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAmusementPark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClosed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWaterPark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStormLand)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(26, 156);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(42, 20);
            this.lbAge.TabIndex = 1;
            this.lbAge.Text = "Age ";
            // 
            // lblSeason
            // 
            this.lblSeason.AutoSize = true;
            this.lblSeason.Location = new System.Drawing.Point(26, 276);
            this.lblSeason.Name = "lblSeason";
            this.lblSeason.Size = new System.Drawing.Size(64, 20);
            this.lblSeason.TabIndex = 2;
            this.lblSeason.Text = "Season (Spring, Summer, Fall or Winter)";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(26, 397);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(100, 20);
            this.lblTemperature.TabIndex = 3;
            this.lblTemperature.Text = "Temperature";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(26, 87);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(237, 26);
            this.txtName.TabIndex = 4;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(26, 189);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(200, 26);
            this.txtAge.TabIndex = 5;
            // 
            // txtSeason
            // 
            this.txtSeason.Location = new System.Drawing.Point(26, 299);
            this.txtSeason.Name = "txtSeason";
            this.txtSeason.Size = new System.Drawing.Size(196, 26);
            this.txtSeason.TabIndex = 6;
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(30, 420);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(192, 26);
            this.txtTemperature.TabIndex = 7;
            // 
            // picAmusementPark
            // 
            this.picAmusementPark.Image = ((System.Drawing.Image)(resources.GetObject("picAmusementPark.Image")));
            this.picAmusementPark.Location = new System.Drawing.Point(420, 85);
            this.picAmusementPark.Name = "picAmusementPark";
            this.picAmusementPark.Size = new System.Drawing.Size(300, 300);
            this.picAmusementPark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAmusementPark.TabIndex = 8;
            this.picAmusementPark.TabStop = false;
            this.picAmusementPark.Visible = false;
            // 
            // picSki
            // 
            this.picSki.Image = ((System.Drawing.Image)(resources.GetObject("picSki.Image")));
            this.picSki.Location = new System.Drawing.Point(420, 85);
            this.picSki.Name = "picSki";
            this.picSki.Size = new System.Drawing.Size(300, 300);
            this.picSki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSki.TabIndex = 9;
            this.picSki.TabStop = false;
            this.picSki.Visible = false;
            // 
            // picClosed
            // 
            this.picClosed.Image = ((System.Drawing.Image)(resources.GetObject("picClosed.Image")));
            this.picClosed.Location = new System.Drawing.Point(420, 85);
            this.picClosed.Name = "picClosed";
            this.picClosed.Size = new System.Drawing.Size(300, 300);
            this.picClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClosed.TabIndex = 10;
            this.picClosed.TabStop = false;
            this.picClosed.Visible = false;
            // 
            // picStormLand
            // 
            this.picStormLand.Image = ((System.Drawing.Image)(resources.GetObject("picStormLand.Image")));
            this.picStormLand.Location = new System.Drawing.Point(420, 85);
            this.picStormLand.Name = "picStormLand";
            this.picStormLand.Size = new System.Drawing.Size(300, 250);
            this.picStormLand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStormLand.TabIndex = 15;
            this.picStormLand.TabStop = false;
            // 
            // picWaterPark
            // 
            this.picWaterPark.Image = ((System.Drawing.Image)(resources.GetObject("picWaterPark.Image")));
            this.picWaterPark.Location = new System.Drawing.Point(420, 85);
            this.picWaterPark.Name = "picWaterPark";
            this.picWaterPark.Size = new System.Drawing.Size(300, 300);
            this.picWaterPark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWaterPark.TabIndex = 11;
            this.picWaterPark.TabStop = false;
            this.picWaterPark.Visible = false;

            // 
            // btnRecommend
            // 
            this.btnRecommend.Location = new System.Drawing.Point(30, 496);
            this.btnRecommend.Name = "btnRecommend";
            this.btnRecommend.Size = new System.Drawing.Size(136, 36);
            this.btnRecommend.TabIndex = 12;
            this.btnRecommend.Text = "Recommend";
            this.btnRecommend.UseVisualStyleBackColor = true;
            this.btnRecommend.Click += new System.EventHandler(this.btnRecommend_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(300, 496);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(577, 496);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 36);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblRide
            // 
            this.lblRide.AutoSize = true;
            this.lblRide.Location = new System.Drawing.Point(470, 440);
            this.lblRide.Name = "lblRide";
            this.lblRide.Size = new System.Drawing.Size(40, 20);
            this.lblRide.TabIndex = 16;
            this.lblRide.ForeColor = System.Drawing.Color.Red;
            this.lblRide.Font = new Font("Verdana", 15);
            // 
            // lblPark
            // 
            this.lblPark.AutoSize = true;
            this.lblPark.Location = new System.Drawing.Point(470, 400);
            this.lblPark.Name = "lblPark";
            this.lblPark.Size = new System.Drawing.Size(40, 20);
            this.lblPark.TabIndex = 17;
            this.lblPark.ForeColor = System.Drawing.Color.Blue;
            this.lblPark.Font = new Font("Verdana", 15);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 550);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Controls.Add(this.lblPark);
            this.Controls.Add(this.lblRide);
            this.Controls.Add(this.picStormLand);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRecommend);
            this.Controls.Add(this.picWaterPark);
            this.Controls.Add(this.picClosed);
            this.Controls.Add(this.picSki);
            this.Controls.Add(this.picAmusementPark);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.txtSeason);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.lblSeason);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "StormLand";
            ((System.ComponentModel.ISupportInitialize)(this.picAmusementPark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClosed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWaterPark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStormLand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lblSeason;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtSeason;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.PictureBox picAmusementPark;
        private System.Windows.Forms.PictureBox picSki;
        private System.Windows.Forms.PictureBox picClosed;
        private System.Windows.Forms.PictureBox picWaterPark;
        private System.Windows.Forms.Button btnRecommend;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picStormLand;
        private System.Windows.Forms.Label lblRide;
        private System.Windows.Forms.Label lblPark;
    }
}

