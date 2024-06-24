using System.Windows.Forms;
using Accord.Imaging.Filters;
using Accord.IO;
using Aspose.Imaging;
using Aspose.Imaging.ImageFilters.FilterOptions;

namespace captcha
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		public static class Cfg
		{
			public static int TextLeng = 7;
			public static int LineN = 30;
			public static int LineWidth = 10;
			public static System.Drawing.Color LineColor = System.Drawing.Color.Blue;
		}
		private string AuthCode = string.Empty;
		private void button1_Click(object sender, EventArgs e)
		{
			char[] text = "qwertyuipasdfghjkzxcvbnm1234567890".ToCharArray();
			string t = String.Empty;
			Random rand = new Random();
			for (int i = 0; i < Cfg.TextLeng; i++)
			{
				t += text[rand.Next(0, text.Length)];
			}
			AuthCode = t;

			Bitmap canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(canvas);
			System.Drawing.Font fnt = new System.Drawing.Font("MS UI Gothic", 150);
			g.DrawString(AuthCode, fnt, Brushes.DarkSlateGray, 10, 50);
			fnt.Dispose();
			System.Drawing.Pen p = new System.Drawing.Pen(Cfg.LineColor, Cfg.LineWidth);
			for (int i = 0; i < Cfg.LineN; i++)
			{
				int LineFP = rand.Next(0, 776);
				int LineWidth = rand.Next(-200, 200);
				g.DrawLine(p, LineFP, 0, LineFP + LineWidth, 350);
			}
			g.Dispose();

			canvas.Save(@"C:\Windows\Temp\aaaa.png");
			using (Aspose.Imaging.Image image = Aspose.Imaging.Image.Load(@"C:\Windows\Temp\aaaa.png"))
			{
				// ‰æ‘œ‚ð RasterImage ‚ÉƒLƒƒƒXƒg‚·‚é
				RasterImage rasterImage = image as RasterImage;
				if (rasterImage == null)
				{
					return;
				}

				GaussWienerFilterOptions options = new GaussWienerFilterOptions(12, 3);
				options.Grayscale = true;
				rasterImage.Filter(image.Bounds, options);

				MemoryStream ms = new MemoryStream();
				image.Save(ms, new Aspose.Imaging.ImageOptions.PngOptions());
				ms.Position = 0;
				Bitmap tempSDI = new Bitmap(ms);
				canvas = tempSDI;
			}

			pictureBox1.Image = canvas;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == AuthCode) textBox1.Text = "ok";
			else textBox1.Text = "nooooo : " + AuthCode;
		}
	}
}
