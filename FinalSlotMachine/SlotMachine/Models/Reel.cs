using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine.Models
{
    internal class Reel
    {
        private string symbolPath;
        private readonly PictureBox pictureBox;
        private static readonly string[] symbolPaths =
        {
            "Resources/Images/A1.png",  // Replace with actual file paths
            "Resources/Images/A2.png",
            "Resources/Images/A3.png",
            "Resources/Images/j1.png",
            "Resources/Images/j2.png",
            "Resources/Images/j3.png",
            "Resources/Images/p1.png",
            "Resources/Images/p2.png",
            "Resources/Images/p3.png",
        };
        private static readonly Random random = new Random();

        public Reel(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            this.pictureBox.Paint += Reel_Paint;
            this.symbolPath = LoadRandomImagePath(); // Initialize with a random image path
        }

        public string SymbolPath
        {
            get => symbolPath;
            private set
            {
                symbolPath = value;
                pictureBox.Invalidate();  // Trigger repaint when the symbol changes
            }
        }

        private void Reel_Paint(object sender, PaintEventArgs e)
        {
            Image image = Image.FromFile(symbolPath);

            // Calculate the new size while maintaining the aspect ratio
            float aspectRatio = (float)image.Width / image.Height;
            int newWidth = pictureBox.Width;
            int newHeight = (int)(newWidth / aspectRatio);

            // If the calculated height is larger than the PictureBox's height, adjust the width instead
            if (newHeight > pictureBox.Height)
            {
                newHeight = pictureBox.Height;
                newWidth = (int)(newHeight * aspectRatio);
            }

            // Resize the image
            Image resizedImage = new Bitmap(image, new Size(newWidth, newHeight));

            // Draw the resized image on the PictureBox
            e.Graphics.DrawImage(resizedImage, new PointF((pictureBox.Width - resizedImage.Width) / 2, (pictureBox.Height - resizedImage.Height) / 2));



        }

        public void Spin()
        {
            // Set a new random symbol path when spinning
            SymbolPath = LoadRandomImagePath();
        }

        private string LoadRandomImagePath()
        {
            return symbolPaths[random.Next(symbolPaths.Length)];
        }
    }
}



