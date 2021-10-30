using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTube___Download
{
    public partial class Form1 : Form
    {
        string url = null;
        string FullUrl = null;
        string DownloadQuality = null;
        public Form1()
        {
            InitializeComponent();

        }
        public void imageRefresh()
        {
            QualityCheck();
            url = videoID.Text;

            pictureBox1.ImageLocation = "https://i1.ytimg.com/vi/" + url + "/" + DownloadQuality + ".jpg";

            //check full url is correct or not correct.
            //label1.Text = pictureBox1.ImageLocation;

            FullUrl = pictureBox1.ImageLocation;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imageRefresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //check Image quality to download
            QualityCheck();
            //create a dialog to ask where to save
            //filter ımage format as JPG
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "(*.jpg)|*.jpg";
            fileDialog.FileName = url + DownloadQuality;


            try
            {
                using (WebClient webClient = new WebClient())
                {
                 
                    if (fileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //SaveUrl, we will use this variable for saving image where user want.
                        string SaveUrl = null;


                        Path.GetFullPath(fileDialog.FileName);
                        SaveUrl = Path.GetFullPath(fileDialog.FileName);
                        webClient.DownloadFile(FullUrl, SaveUrl);


                        MessageBox.Show("Image Downloaded Successfully");
                    }
                }
            }

            //show 404 image error and a message to user
            catch (Exception)
            {

                MessageBox.Show("Image Download Failed. Please check your Video ID or internet connection");

            }

        }

        //Image Quality Check.
        public void QualityCheck()
        {
            if (MaxResDefault.Checked == true)
            {
                DownloadQuality = "maxresdefault";
            }
            else if (HqDefault.Checked == true)
            {
                DownloadQuality = "hqdefault";
            }
            else if (SdDefault.Checked == true)
            {
                DownloadQuality = "sddefault";
            }
            else if (MqDefault.Checked == true)
            {
                DownloadQuality = "mqdefault";
            }
            else
            {
                DownloadQuality = "default";
            }
            pictureBox1.ImageLocation = "https://i1.ytimg.com/vi/" + url + "/" + DownloadQuality + ".jpg";

        }


        private void Default_CheckedChanged(object sender, EventArgs e)
        {
            imageRefresh();
        }

        private void MqDefault_CheckedChanged(object sender, EventArgs e)
        {
            imageRefresh();

        }

        private void HqDefault_CheckedChanged(object sender, EventArgs e)
        {
            imageRefresh();

        }

        private void SdDefault_CheckedChanged(object sender, EventArgs e)
        {
            imageRefresh();


        }

        private void MaxResDefault_CheckedChanged(object sender, EventArgs e)
        {
            imageRefresh();

        }

        private void videoID_TextChanged(object sender, EventArgs e)
        {
            imageRefresh();


        }

        private void videoID_TextChanged_1(object sender, EventArgs e)
        {
            imageRefresh();
        }
    }
}
