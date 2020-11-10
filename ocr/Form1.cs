using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Tesseract;

namespace ocr
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			try
			{
				var fb = new FolderBrowserDialog();
				if (fb.ShowDialog() == DialogResult.OK)
				{
					tbxDirectory.Text = fb.SelectedPath;   // hiển thị ảnh
					LoadImgFromFolder(tbxDirectory.Text);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("lỗi ảnh : " + ex.Message + " " + ex.Source);
			}

		}

		private void LoadImgFromFolder(string currentDir)
		{
			var dirInfor = new DirectoryInfo(currentDir);
			var Files = dirInfor.GetFiles().Where(c => (c.Extension.Equals(".jpg") || c.Extension.Equals(".jpeg") || c.Extension.Equals(".bmp") || c.Extension.Equals(".png")));
			foreach (var image in Files)
			{
				listImages.Items.Add(image.Name);
			}
		}

		private void listImages_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedImage = listImages.SelectedItems[0].ToString();
			if (!string.IsNullOrEmpty(selectedImage) && !string.IsNullOrEmpty(tbxDirectory.Text))
			{
				var fullpath = Path.Combine(tbxDirectory.Text, selectedImage);

				imgPreview.Image = Image.FromFile(fullpath);

			}
		}

		private void btnOCR_Click(object sender, EventArgs e)
		{
			var bmp = (imgPreview.Image);
			if (bmp == null)
			{
				MessageBox.Show("Chưa chọn hình", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
		}

		private string GetAbsolutePath(Assembly assembly, string relativePath)
		{
			var assemblyFolderPath = new FileInfo(assembly.Location).Directory.FullName;
			return Path.GetFullPath(Path.Combine(assemblyFolderPath, relativePath));
		}

		private void ảnh_Load(object sender, EventArgs e)
		{
			string imgPath = GetAbsolutePath(typeof(Program).Assembly, "../../img");
			tbxDirectory.Text = imgPath;
			LoadImgFromFolder(imgPath);
		}

		private string OCR(Bitmap bitmap)
		{
			string res = "";
			using (var engine = new TesseractEngine(@"tessdata", "eng", EngineMode.Default))
			{
				engine.SetVariable("tessedit_char_whitelist", "1234567890");
				engine.SetVariable("tessedit_unrej_any_wd", true);

				using (var page = engine.Process(bitmap, PageSegMode.SingleLine))
					res = page.GetText();
			}
			return res;
		}

		private void FindContour(Bitmap bitmap)
		{
			Image<Rgb, Byte> colorfulImage = new Image<Rgb, byte>(bitmap);
			using (MemStorage storage = new MemStorage()) //allocate storage for contour approximation
			{
				for (Contour<Point> contours = colorfulImage.FindContours(
					Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE,
					Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_LIST,
					storage);
					contours != null;
					contours = contours.HNext)
				{
					Contour<Point> currentContour = contours.ApproxPoly(contours.Perimeter * 0.05, storage);
					//Debug.WriteLine(currentContour.Area);

					if (currentContour.Area > 250) //only consider contours with area greater than 250
					{
						if (currentContour.Total == 4) //The contour has 4 vertices.
						{
							//if (IsRectangle(currentContour))
							//{
							//	m_FoundRectangles.Add(currentContour.GetMinAreaRect());
							//}
						}
					}
				}
			}
		}
	}
}
