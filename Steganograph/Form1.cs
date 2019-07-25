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
using System.IO;

namespace Steganograph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Bitmap Img { get; set; }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog {
                Filter = "Image|*.png;*.jpg;*.jpeg;*.bmp;*.tiff|PNG Image|*.png|JPG Image|*.jpg|Bitmap Image|*.bmp|TIFF Image|*.tiff",
                Title = "Choose an image to embed"
            };
            //Display image in pictureBox and enable textBox and the embed button
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Img = new Bitmap(ofd.FileName);
                pictureEmbed.Image = Img;
                textEmbed.Enabled = true;
                textEmbed.Text = String.Empty;
                ButtonEmbed.Enabled = true;
            }
        }
        
        private void ButtonChoseRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog {
                Filter = "Image|*.png;*.jpg;*.jpeg;*.bmp;*.tiff|PNG Image|*.png|JPG Image|*.jpg|Bitmap Image|*.bmp|TIFF Image|*.tiff",
                Title = "Choose an image to read"
            };
            //Display image in pictureBox and call ReadMessage function
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureRead.Image = new Bitmap(ofd.FileName);
                textRead.Text = ReadMessage(new Bitmap(ofd.FileName));
            }
        }
        
        private void Button2_Click(object sender, EventArgs e)
        {
            CheckMessage(textEmbed.Text);
        }

        //Check if the message isn't null and if the picture has enough pixels to hold it
        private void CheckMessage(string message)
        {
            if (message.Length == 0) 
            {
                MessageBox.Show("You need to write a message");
                return;
            }
            else if ((message.Length + 1) * 8 > Img.Width * Img.Height)
            {
                MessageBox.Show("Message too long for this picture"); 
                return;
            }
            EmbedMessage(message);
        }

        //Embed the message in the picture
        private void EmbedMessage(string message)
        {
            int PixelX = 0, PixelY = 0;
            message += '\0';
            //Loop through each character
            for (int x = 0; x < message.Length; x++)
            {
                int character = message[x];
                //Loop through every bit of the character
                //and change the pixel's LSB with it
                for (int i = 0; i < 8; i++, character /= 2)
                {
                    Color pixelColor = Img.GetPixel(PixelX, PixelY);
                    try
                    {
                        Img.SetPixel(PixelX, PixelY,
                                      Color.FromArgb(pixelColor.R / 2 * 2 + character % 2,
                                                     pixelColor.G,
                                                     pixelColor.B));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("This picture has indexed pixels and can't be embedded\nConvert it to another format or try another one");
                        return;
                    }
                    if (PixelX == Img.Width - 1)
                    {
                        PixelY++;
                        PixelX = 0;
                    }
                    else PixelX++;
                }
            }
            SaveImage();
        }

        private void SaveImage()
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog
                {
                    Filter = "PNG Image|*.png|Bitmap Image|*.bmp|TIFF Image|*.tiff",
                    Title = "Save embedded piture"
                };
                save.ShowDialog();

                System.IO.FileStream fs = (System.IO.FileStream)save.OpenFile();
                switch (save.FilterIndex)
                {
                    case 1:
                        Img.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    case 2:
                        Img.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case 3:
                        Img.Save(fs, System.Drawing.Imaging.ImageFormat.Tiff);
                        break;
                }
                fs.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to save Image");
            }
        }

        //Decode the text in a bitmap
        private string ReadMessage(Bitmap img)
        {
            string text = String.Empty;
            int bit = 1, character = 0;
            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    Color pixel = img.GetPixel(x, y);
                    character += (pixel.R % 2) * (int)Math.Pow(2, bit - 1);
                    if (bit % 8 == 0)
                    {
                        if (character == 0)
                            return text;
                        text += (char)character;
                        bit = 0;
                        character = 0;
                    }
                    bit++;
                }
            }
            return text;
        }
    }
}