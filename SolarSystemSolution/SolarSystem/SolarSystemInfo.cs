using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolarSystem
{
    public partial class SolarSystemInfo : Form
    {
        public SolarSystemInfo()
        {
            InitializeComponent();
        }

        public SolarSystemInfo(IContainer components, ComboBox comboBox1, PictureBox sunPictureBox, PictureBox venusPictureBox, PictureBox marsPictureBox, PictureBox earthPictureBox, Label chooseLabel)
        {
            this.components = components;
            this.comboBox1 = comboBox1;
            SunPictureBox = sunPictureBox;
            this.venusPictureBox = venusPictureBox;
            this.marsPictureBox = marsPictureBox;
            this.earthPictureBox = earthPictureBox;
            this.chooseLabel = chooseLabel;
        }

        private void SolarSystemInfo_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(comboBox1.SelectedIndex == 0)
            {
                solarSysPicBox.Visible = false;
                SunPictureBox.Visible = true;
                mercuryPictureBox.Visible = false;
                venusPictureBox.Visible = false;
                earthPictureBox.Visible = false;
                marsPictureBox.Visible = false;
                jupiterPictureBox.Visible = false;
                saturnPictureBox.Visible = false;
                uranusPictureBox.Visible = false;
                neptunePictureBox.Visible = false;
                plutoPictureBox.Visible = false;
                
            }
            if (comboBox1.SelectedIndex == 1)
            {
                solarSysPicBox.Visible = false;
                SunPictureBox.Visible = false;
                mercuryPictureBox.Visible = true;
                venusPictureBox.Visible = false;
                earthPictureBox.Visible = false;
                marsPictureBox.Visible = false;
                jupiterPictureBox.Visible = false;
                saturnPictureBox.Visible = false;
                uranusPictureBox.Visible = false;
                neptunePictureBox.Visible = false;
                plutoPictureBox.Visible = false;

            }
            if (comboBox1.SelectedIndex == 2)
            {
                solarSysPicBox.Visible = false;
                SunPictureBox.Visible = false;
                mercuryPictureBox.Visible = false;
                venusPictureBox.Visible = true;
                earthPictureBox.Visible = false;
                marsPictureBox.Visible = false;
                jupiterPictureBox.Visible = false;
                saturnPictureBox.Visible = false;
                uranusPictureBox.Visible = false;
                neptunePictureBox.Visible = false;
                plutoPictureBox.Visible = false;

            }
            if (comboBox1.SelectedIndex == 3)
            {
                solarSysPicBox.Visible = false;
                SunPictureBox.Visible = false;
                mercuryPictureBox.Visible = false;
                venusPictureBox.Visible = false;
                earthPictureBox.Visible = true;
                marsPictureBox.Visible = false;
                jupiterPictureBox.Visible = false;
                saturnPictureBox.Visible = false;
                uranusPictureBox.Visible = false;
                neptunePictureBox.Visible = false;
                plutoPictureBox.Visible = false;

            }
            if (comboBox1.SelectedIndex == 4)
            {
                solarSysPicBox.Visible = false;
                SunPictureBox.Visible = false;
                mercuryPictureBox.Visible = false;
                venusPictureBox.Visible = false;
                earthPictureBox.Visible = false;
                marsPictureBox.Visible = true;
                jupiterPictureBox.Visible = false;
                saturnPictureBox.Visible = false;
                uranusPictureBox.Visible = false;
                neptunePictureBox.Visible = false;
                plutoPictureBox.Visible = false;

            }
            if (comboBox1.SelectedIndex == 5)
            {
                solarSysPicBox.Visible = false;
                SunPictureBox.Visible = false;
                mercuryPictureBox.Visible = false;
                venusPictureBox.Visible = false;
                earthPictureBox.Visible = false;
                marsPictureBox.Visible = false;
                jupiterPictureBox.Visible = true;
                saturnPictureBox.Visible = false;
                uranusPictureBox.Visible = false;
                neptunePictureBox.Visible = false;
                plutoPictureBox.Visible = false;

            }
            if (comboBox1.SelectedIndex == 6)
            {
                solarSysPicBox.Visible = false;
                SunPictureBox.Visible = false;
                mercuryPictureBox.Visible = false;
                venusPictureBox.Visible = false;
                earthPictureBox.Visible = false;
                marsPictureBox.Visible = false;
                jupiterPictureBox.Visible = false;
                saturnPictureBox.Visible = true;
                uranusPictureBox.Visible = false;
                neptunePictureBox.Visible = false;
                plutoPictureBox.Visible = false;

            }
            if (comboBox1.SelectedIndex == 7)
            {
                solarSysPicBox.Visible = false;
                SunPictureBox.Visible = false;
                mercuryPictureBox.Visible = false;
                venusPictureBox.Visible = false;
                earthPictureBox.Visible = false;
                marsPictureBox.Visible = false;
                jupiterPictureBox.Visible = false;
                saturnPictureBox.Visible = false;
                uranusPictureBox.Visible = true;
                neptunePictureBox.Visible = false;
                plutoPictureBox.Visible = false;

            }
            if (comboBox1.SelectedIndex == 8)
            {
                solarSysPicBox.Visible = false;
                SunPictureBox.Visible = false;
                mercuryPictureBox.Visible = false;
                venusPictureBox.Visible = false;
                earthPictureBox.Visible = false;
                marsPictureBox.Visible = false;
                jupiterPictureBox.Visible = false;
                saturnPictureBox.Visible = false;
                uranusPictureBox.Visible = false;
                neptunePictureBox.Visible = true;
                plutoPictureBox.Visible = false;

            }
            if (comboBox1.SelectedIndex == 9)
            {
                solarSysPicBox.Visible = false;
                SunPictureBox.Visible = false;
                mercuryPictureBox.Visible = false;
                venusPictureBox.Visible = false;
                earthPictureBox.Visible = false;
                marsPictureBox.Visible = false;
                jupiterPictureBox.Visible = false;
                saturnPictureBox.Visible = false;
                uranusPictureBox.Visible = false;
                neptunePictureBox.Visible = false;
                plutoPictureBox.Visible = true;

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
    }
}
