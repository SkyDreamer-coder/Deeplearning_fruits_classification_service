using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;


namespace Meyve_bankasi_app
{
    public partial class Camera : Form
    {

        Model_controller model;
        public Camera()
        {
            InitializeComponent();
        }

        FilterInfoCollection fico;
        VideoCaptureDevice vcd;

        private void Camera_Load(object sender, EventArgs e)
        {
            fico = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo f in fico)
            {
                comboBox1.Items.Add(f.Name);
                comboBox1.SelectedIndex = 0;
            }
        }

   
        private void Vcd_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btn_yakala_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "(*.jpg)|*.jpg";
            DialogResult dr = s.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pictureBox1.Image.Save(s.FileName);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            try
            {
                if(vcd!= null)
                {
                    vcd.Stop();
                    Uygulama form1 = new Uygulama();
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    Uygulama form1 = new Uygulama();
                    form1.Show();
                    this.Hide();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
            
        }

        private void btn_picture_select_Click(object sender, EventArgs e)
        {
            OpenFileDialog s = new OpenFileDialog();
            if(s.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(s.FileName);
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            vcd = new VideoCaptureDevice(fico[comboBox1.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame;
            vcd.Start();
        }

        private void btn_detect_Click(object sender, EventArgs e)
        {
            if(vcd != null)
            {
                vcd.Stop();
                if (pictureBox1.Image == null)
                {
                    string folder;
                    OpenFileDialog s = new OpenFileDialog();
                    if (s.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox1.Image = Image.FromFile(s.FileName);
                        folder = Path.Combine(s.FileName);
                    }
                    model = new Model_controller(Convert.ToString(Path.Combine(s.FileNames)));

                    model.predict();
                }
                else
                {
                    pictureBox1.Image = null;
                    string folder;
                    OpenFileDialog s = new OpenFileDialog();
                    if (s.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox1.Image = Image.FromFile(s.FileName);
                        folder = s.FileName;
                    }
                    model = new Model_controller(s.ToString());

                    model.predict();
                }
            }
            else
            {
                string folder;
                OpenFileDialog s = new OpenFileDialog();
                if (s.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(s.FileName);
                    folder = Path.Combine(s.FileName);
                }
                model = new Model_controller(Convert.ToString(Path.Combine(s.FileNames)));

                model.predict();
            }
            
        }
    }
}
