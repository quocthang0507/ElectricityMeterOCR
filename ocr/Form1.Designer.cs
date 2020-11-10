namespace ocr
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.listImages = new System.Windows.Forms.ListBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.imgPreview = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.rtbContent = new System.Windows.Forms.RichTextBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tbxDirectory = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnOCR = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgPreview)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.listImages);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(345, 437);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ảnh";
			// 
			// listImages
			// 
			this.listImages.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listImages.FormattingEnabled = true;
			this.listImages.ItemHeight = 17;
			this.listImages.Location = new System.Drawing.Point(3, 19);
			this.listImages.Name = "listImages";
			this.listImages.Size = new System.Drawing.Size(339, 415);
			this.listImages.TabIndex = 5;
			this.listImages.SelectedIndexChanged += new System.EventHandler(this.listImages_SelectedIndexChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.imgPreview);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(3, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(515, 212);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Hiển thị ảnh";
			// 
			// imgPreview
			// 
			this.imgPreview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.imgPreview.Location = new System.Drawing.Point(3, 19);
			this.imgPreview.Name = "imgPreview";
			this.imgPreview.Size = new System.Drawing.Size(509, 190);
			this.imgPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgPreview.TabIndex = 0;
			this.imgPreview.TabStop = false;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 115);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(878, 443);
			this.tableLayoutPanel1.TabIndex = 9;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(354, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(521, 437);
			this.tableLayoutPanel2.TabIndex = 10;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.rtbContent);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(3, 221);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(515, 213);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Văn bản";
			// 
			// rtbContent
			// 
			this.rtbContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbContent.Location = new System.Drawing.Point(3, 19);
			this.rtbContent.Name = "rtbContent";
			this.rtbContent.ReadOnly = true;
			this.rtbContent.Size = new System.Drawing.Size(509, 191);
			this.rtbContent.TabIndex = 5;
			this.rtbContent.Text = "";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(884, 561);
			this.tableLayoutPanel3.TabIndex = 10;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tbxDirectory);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnOpen);
			this.panel1.Controls.Add(this.btnOCR);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(878, 106);
			this.panel1.TabIndex = 10;
			// 
			// tbxDirectory
			// 
			this.tbxDirectory.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tbxDirectory.Location = new System.Drawing.Point(200, 14);
			this.tbxDirectory.Name = "tbxDirectory";
			this.tbxDirectory.Size = new System.Drawing.Size(501, 23);
			this.tbxDirectory.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(90, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 17);
			this.label1.TabIndex = 12;
			this.label1.Text = "Đường dẫn:";
			// 
			// btnOpen
			// 
			this.btnOpen.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnOpen.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnOpen.Location = new System.Drawing.Point(754, 9);
			this.btnOpen.MaximumSize = new System.Drawing.Size(115, 33);
			this.btnOpen.MinimumSize = new System.Drawing.Size(115, 33);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(115, 33);
			this.btnOpen.TabIndex = 2;
			this.btnOpen.Text = "Open path";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// btnOCR
			// 
			this.btnOCR.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnOCR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnOCR.Location = new System.Drawing.Point(396, 43);
			this.btnOCR.Name = "btnOCR";
			this.btnOCR.Size = new System.Drawing.Size(101, 36);
			this.btnOCR.TabIndex = 3;
			this.btnOCR.Text = "Chuyển đổi";
			this.btnOCR.UseVisualStyleBackColor = true;
			this.btnOCR.Click += new System.EventHandler(this.btnOCR_Click);
			// 
			// Form1
			// 
			this.AcceptButton = this.btnOCR;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(884, 561);
			this.Controls.Add(this.tableLayoutPanel3);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.Name = "Form1";
			this.Text = "Hiển Thị Hình ảnh";
			this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.Load += new System.EventHandler(this.ảnh_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.imgPreview)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listImages;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox imgPreview;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.RichTextBox rtbContent;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox tbxDirectory;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Button btnOCR;
		private System.Windows.Forms.GroupBox groupBox3;
	}
}

