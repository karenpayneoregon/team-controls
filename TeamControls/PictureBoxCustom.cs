using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace TeamControls
{
    public class PictureBoxCustom : PictureBox
    {
        [Category("Behavior"), Description("Identifier")]
        public int Id { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public bool HasId => Id > -1;

        [Category("Behavior"), Description("Stash")]
        public string Stash { get; set; }

        public void ExportToFile(string path)
        {
            using var bitmap = new Bitmap(Width, Height);
            DrawToBitmap(bitmap, ClientRectangle);
            ImageFormat imageFormat = null;

            var extension = Path.GetExtension(path);
            imageFormat = extension switch
            {
                ".bmp" => ImageFormat.Bmp,
                ".png" => ImageFormat.Png,
                ".jpeg" => ImageFormat.Jpeg,
                ".jpg" => ImageFormat.Jpeg,
                ".gif" => ImageFormat.Gif,
                _ => throw new NotSupportedException("File extension is not supported")
            };

            bitmap.Save(path, imageFormat);
        }
    }
}