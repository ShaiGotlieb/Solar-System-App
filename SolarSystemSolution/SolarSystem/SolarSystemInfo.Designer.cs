namespace SolarSystem
{
    partial class SolarSystemInfo
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.mercuryPictureBox = new System.Windows.Forms.PictureBox();
            this.solarSysPicBox = new System.Windows.Forms.PictureBox();
            this.marsPictureBox = new System.Windows.Forms.PictureBox();
            this.SunPictureBox = new System.Windows.Forms.PictureBox();
            this.venusPictureBox = new System.Windows.Forms.PictureBox();
            this.earthPictureBox = new System.Windows.Forms.PictureBox();
            this.jupiterPictureBox = new System.Windows.Forms.PictureBox();
            this.saturnPictureBox = new System.Windows.Forms.PictureBox();
            this.uranusPictureBox = new System.Windows.Forms.PictureBox();
            this.neptunePictureBox = new System.Windows.Forms.PictureBox();
            this.plutoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mercuryPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solarSysPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venusPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.earthPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jupiterPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturnPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uranusPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neptunePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plutoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "השמש",
            "כוכב חמה",
            "נגה",
            "כדור הארץ",
            "מאדים",
            "צדק",
            "שבתאי",
            "אורנוס",
            "נפטון",
            "פלוטו"});
            this.comboBox1.Location = new System.Drawing.Point(658, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.chooseLabel.Location = new System.Drawing.Point(622, 32);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(188, 34);
            this.chooseLabel.TabIndex = 6;
            this.chooseLabel.Text = "בחר\\י כוכב לכת";
            // 
            // mercuryPictureBox
            // 
            this.mercuryPictureBox.Image = global::SolarSystem.Properties.Resources.Mercury;
            this.mercuryPictureBox.Location = new System.Drawing.Point(-70, 3);
            this.mercuryPictureBox.Name = "mercuryPictureBox";
            this.mercuryPictureBox.Size = new System.Drawing.Size(686, 634);
            this.mercuryPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mercuryPictureBox.TabIndex = 8;
            this.mercuryPictureBox.TabStop = false;
            this.mercuryPictureBox.Visible = false;
            // 
            // solarSysPicBox
            // 
            this.solarSysPicBox.Image = global::SolarSystem.Properties.Resources.solar_planetary_system_animation_4;
            this.solarSysPicBox.Location = new System.Drawing.Point(-70, 3);
            this.solarSysPicBox.Name = "solarSysPicBox";
            this.solarSysPicBox.Size = new System.Drawing.Size(686, 634);
            this.solarSysPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.solarSysPicBox.TabIndex = 7;
            this.solarSysPicBox.TabStop = false;
            // 
            // marsPictureBox
            // 
            this.marsPictureBox.Image = global::SolarSystem.Properties.Resources.mars;
            this.marsPictureBox.Location = new System.Drawing.Point(-70, 3);
            this.marsPictureBox.Name = "marsPictureBox";
            this.marsPictureBox.Size = new System.Drawing.Size(686, 634);
            this.marsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.marsPictureBox.TabIndex = 4;
            this.marsPictureBox.TabStop = false;
            this.marsPictureBox.Visible = false;
            // 
            // SunPictureBox
            // 
            this.SunPictureBox.Image = global::SolarSystem.Properties.Resources.sun;
            this.SunPictureBox.Location = new System.Drawing.Point(-70, 3);
            this.SunPictureBox.Name = "SunPictureBox";
            this.SunPictureBox.Size = new System.Drawing.Size(686, 634);
            this.SunPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SunPictureBox.TabIndex = 2;
            this.SunPictureBox.TabStop = false;
            this.SunPictureBox.Visible = false;
            // 
            // venusPictureBox
            // 
            this.venusPictureBox.Image = global::SolarSystem.Properties.Resources.Venus;
            this.venusPictureBox.Location = new System.Drawing.Point(-70, 3);
            this.venusPictureBox.Name = "venusPictureBox";
            this.venusPictureBox.Size = new System.Drawing.Size(686, 634);
            this.venusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.venusPictureBox.TabIndex = 3;
            this.venusPictureBox.TabStop = false;
            this.venusPictureBox.Visible = false;
            // 
            // earthPictureBox
            // 
            this.earthPictureBox.Image = global::SolarSystem.Properties.Resources.Earth;
            this.earthPictureBox.Location = new System.Drawing.Point(-70, 3);
            this.earthPictureBox.Name = "earthPictureBox";
            this.earthPictureBox.Size = new System.Drawing.Size(686, 634);
            this.earthPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.earthPictureBox.TabIndex = 5;
            this.earthPictureBox.TabStop = false;
            this.earthPictureBox.Visible = false;
            // 
            // jupiterPictureBox
            // 
            this.jupiterPictureBox.Image = global::SolarSystem.Properties.Resources.Jupiter;
            this.jupiterPictureBox.Location = new System.Drawing.Point(-70, 3);
            this.jupiterPictureBox.Name = "jupiterPictureBox";
            this.jupiterPictureBox.Size = new System.Drawing.Size(686, 634);
            this.jupiterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jupiterPictureBox.TabIndex = 9;
            this.jupiterPictureBox.TabStop = false;
            this.jupiterPictureBox.Visible = false;
            // 
            // saturnPictureBox
            // 
            this.saturnPictureBox.Image = global::SolarSystem.Properties.Resources.Saturn;
            this.saturnPictureBox.Location = new System.Drawing.Point(-70, 3);
            this.saturnPictureBox.Name = "saturnPictureBox";
            this.saturnPictureBox.Size = new System.Drawing.Size(686, 634);
            this.saturnPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.saturnPictureBox.TabIndex = 10;
            this.saturnPictureBox.TabStop = false;
            this.saturnPictureBox.Visible = false;
            // 
            // uranusPictureBox
            // 
            this.uranusPictureBox.Image = global::SolarSystem.Properties.Resources.uranus;
            this.uranusPictureBox.Location = new System.Drawing.Point(-70, 3);
            this.uranusPictureBox.Name = "uranusPictureBox";
            this.uranusPictureBox.Size = new System.Drawing.Size(686, 634);
            this.uranusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uranusPictureBox.TabIndex = 11;
            this.uranusPictureBox.TabStop = false;
            this.uranusPictureBox.Visible = false;
            // 
            // neptunePictureBox
            // 
            this.neptunePictureBox.Image = global::SolarSystem.Properties.Resources.Neptune;
            this.neptunePictureBox.Location = new System.Drawing.Point(-70, 3);
            this.neptunePictureBox.Name = "neptunePictureBox";
            this.neptunePictureBox.Size = new System.Drawing.Size(686, 634);
            this.neptunePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.neptunePictureBox.TabIndex = 12;
            this.neptunePictureBox.TabStop = false;
            this.neptunePictureBox.Visible = false;
            // 
            // plutoPictureBox
            // 
            this.plutoPictureBox.Image = global::SolarSystem.Properties.Resources.pluto;
            this.plutoPictureBox.Location = new System.Drawing.Point(-70, 3);
            this.plutoPictureBox.Name = "plutoPictureBox";
            this.plutoPictureBox.Size = new System.Drawing.Size(686, 634);
            this.plutoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.plutoPictureBox.TabIndex = 13;
            this.plutoPictureBox.TabStop = false;
            this.plutoPictureBox.Visible = false;
            // 
            // SolarSystemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(810, 631);
            this.Controls.Add(this.uranusPictureBox);
            this.Controls.Add(this.saturnPictureBox);
            this.Controls.Add(this.jupiterPictureBox);
            this.Controls.Add(this.mercuryPictureBox);
            this.Controls.Add(this.solarSysPicBox);
            this.Controls.Add(this.chooseLabel);
            this.Controls.Add(this.marsPictureBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SunPictureBox);
            this.Controls.Add(this.venusPictureBox);
            this.Controls.Add(this.earthPictureBox);
            this.Controls.Add(this.plutoPictureBox);
            this.Controls.Add(this.neptunePictureBox);
            this.Name = "SolarSystemInfo";
            this.Text = "מערכת השמש";
            this.Load += new System.EventHandler(this.SolarSystemInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mercuryPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solarSysPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venusPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.earthPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jupiterPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturnPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uranusPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neptunePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plutoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox SunPictureBox;
        private System.Windows.Forms.PictureBox venusPictureBox;
        private System.Windows.Forms.PictureBox marsPictureBox;
        private System.Windows.Forms.PictureBox earthPictureBox;
        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.PictureBox solarSysPicBox;
        private System.Windows.Forms.PictureBox mercuryPictureBox;
        private System.Windows.Forms.PictureBox jupiterPictureBox;
        private System.Windows.Forms.PictureBox saturnPictureBox;
        private System.Windows.Forms.PictureBox uranusPictureBox;
        private System.Windows.Forms.PictureBox neptunePictureBox;
        private System.Windows.Forms.PictureBox plutoPictureBox;
    }
}

