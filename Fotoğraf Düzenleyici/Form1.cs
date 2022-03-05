using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fotoğraf_Düzenleyici
{
    public partial class Form1 : Form
    {
        public int effect_number = 0;
        public Image ori_image = null;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            ToolTip tool_tip = new ToolTip();
            tool_tip.SetToolTip(effect_1_button, "Adding a picture Pale effect");
            tool_tip.SetToolTip(effect_2_button, "Adding a picture Blue effect");
            tool_tip.SetToolTip(effect_3_button, "Adding a picture Grey effect");
            tool_tip.SetToolTip(effect_4_button, "Adding a picture Invert effect");
            tool_tip.SetToolTip(effect_5_button, "Adding a picture Invert 2 effect");
            tool_tip.SetToolTip(effect_6_button, "Adding a picture Live effect");
            tool_tip.SetToolTip(effect_7_button, "Adding a picture Red effect");
        }

        // New item click event in menu.
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                picture_area.Image = new Bitmap(open.FileName);
                ori_image = picture_area.Image;
            }            
        }

        // Save item click event in menu.
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picture_area.Image == null)
            {
                MessageBox.Show("Picture is not selected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SaveFileDialog save = new SaveFileDialog();
                // image filters
                save.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    picture_area.Image.Save(save.FileName, ImageFormat.Png);
                }
            }
        }

        // Original item click event in menu .
        private void originalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ori_image == null)
            {
                MessageBox.Show("Picture is not selected","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            { picture_area.Image = ori_image; }
        }


        public void button_click(object sender ,EventArgs e)
        {
            if (picture_area.Image == null)
            { MessageBox.Show("Picture is not selected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            else
            {
                Button cliked_button = (Button)sender;

                if (cliked_button.Text == "Pale")
                { effect_number = 1; }
                if (cliked_button.Text == "Blue")
                { effect_number = 2; }
                if (cliked_button.Text == "Grey")
                { effect_number = 3; }
                if (cliked_button.Text == "Invert")
                { effect_number = 4; }
                if (cliked_button.Text == "Invert 2")
                { effect_number = 5; }
                if (cliked_button.Text == "Live")
                { effect_number = 6; }
                if (cliked_button.Text == "Red")
                { effect_number = 7; }





                if (effect_thread.IsBusy == true)
                {
                    effect_thread.WorkerSupportsCancellation = true;
                    effect_thread.CancelAsync();
                }
                else
                {
                    effect_thread.RunWorkerAsync();
                }
            }    
        }

        private void effect_thread_DoWork(object sender, DoWorkEventArgs e)
        {
            Image img = picture_area.Image;
            bitmap_algorithms effect_alg = new bitmap_algorithms();

            if (effect_number == 1)
                picture_area.Image = (effect_alg.pale(img));
            if (effect_number == 2)
                picture_area.Image = (effect_alg.Blue(img));
            if (effect_number == 3)
                picture_area.Image = (effect_alg.Grey(img));
            if (effect_number == 4)
                picture_area.Image = (effect_alg.Invert(img));
            if (effect_number == 5)
                picture_area.Image = (effect_alg.Invert_2(img));
            if (effect_number == 6)
                picture_area.Image = (effect_alg.live(img));
            if (effect_number == 7)
                picture_area.Image = (effect_alg.red(img));
        }
    }
}