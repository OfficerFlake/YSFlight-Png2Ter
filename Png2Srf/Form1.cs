using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Png2Srf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);
        }

        void Form1_DragEnter(object sender, DragEventArgs e) {
          if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (!file.ToUpperInvariant().EndsWith(".PNG"))
                {
                    DropLabel.Text = "Dropped File is NOT a PNG File!\nCannot convert to TER!";
                    DropLabel.ForeColor = Color.FromArgb(0, 255, 0, 0);
                    continue;
                }

                int TotalNodes = 0;
                double Width = 0;
                double Height = 0;

                try
                {
                    DropLabel.Text = "Working...";
                    DropLabel.ForeColor = Color.FromArgb(0, 255, 220, 0);
                    this.Refresh();
                    Bitmap bitmap = new Bitmap(file);

                    if (bitmap.Width * bitmap.Height > (128 * 128))
                    {
                        DialogResult result = MessageBox.Show("That's a very large PNG file to convert! (> 128^2 pixels to be converted to TER)... Are you sure about this?", "Uh Oh!", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.Cancel)
                        {
                            DropLabel.Text = "Drop Input PNG Here!";
                            DropLabel.ForeColor = Color.FromArgb(0, 255, 255, 255);
                            return;
                        }
                    }

                    List<string> TERFileOutput = new List<string>();
                    TERFileOutput.Add("TERRMESH");

                    TotalNodes = bitmap.Width*bitmap.Height;

                    Width = bitmap.Width;
                    Height = bitmap.Height;
                    Double.TryParse(textBox_Width.Text, out Width);
                    Double.TryParse(textBox_Height.Text, out Height);
                    if (Width <= 0) Width = bitmap.Width;
                    if (Height <= 0) Height = bitmap.Height;

                    double MaxNodeHeight = 255;
                    Double.TryParse(textBox_MaxNodeHeight.Text, out MaxNodeHeight);
                    double HeightScaling = MaxNodeHeight / 255;

                    TERFileOutput.Add("NBL " + (bitmap.Width-1) + " " + (bitmap.Height-1));//1px == 1 node.
                    TERFileOutput.Add("TMS " + Math.Round(((Width)/(bitmap.Width-1)), 2) + " " + Math.Round(((Height)/(bitmap.Height-1)), 2)); //as set by dialoge control

                    //Add all the vertecies!
                    for (int currentHeight = bitmap.Height-1; currentHeight >= 0; currentHeight--)
                    {
                        for (int currentWidth = 0; currentWidth < bitmap.Width; currentWidth++)
                        {
                            Color currentPixel = bitmap.GetPixel(currentWidth, currentHeight);
                            float currentBrightness = currentPixel.GetBrightness();
                            string faceVisible = (currentBrightness <= 0) ? "0" : "1";
                            faceVisible = "1"; //Always visible, can set visibility of zero elev faces in scenery editor.

                            //Color pixel = bitmap.GetPixel(j, i);
                            TERFileOutput.Add("BLO " + //ADD BLOCK
                                Math.Round((currentBrightness * HeightScaling) * 255, 0) + " " + //HEIGHT 0-100
                                "R " + 
                                faceVisible + " " +
                                currentPixel.R + " " +
                                currentPixel.G + " " +
                                currentPixel.B + " " +
                                faceVisible + " " +
                                currentPixel.R + " " +
                                currentPixel.G + " " +
                                currentPixel.B
                            ); //NODE
                        }
                    }
                    TERFileOutput.Add("END");

                    string outputFilePath = Path.GetDirectoryName(file) + "\\" + Path.GetFileNameWithoutExtension(file) +
                                            ".TER";

                    File.WriteAllLines(outputFilePath, TERFileOutput.ToArray());

                    bitmap.Dispose();
                }
                catch
                {
                    DropLabel.Text = "Conversion Failed! Something Broke!";
                    DropLabel.ForeColor = Color.FromArgb(0, 255, 0, 0);
                    return;
                }

                DropLabel.Text = "Done (" + TotalNodes + " Nodes)!\nDrop Another PNG to Convert...";
                DropLabel.ForeColor = Color.FromArgb(0, 0, 255, 0);
                return;
            }
        }
    }
}
