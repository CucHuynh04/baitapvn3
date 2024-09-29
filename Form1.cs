using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Mở  hộp thoại chọn file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Tạo form con để hiển thị ảnh
                Form childForm = new Form();
                childForm.MdiParent = this; // Đặt form con thuộc form cha

                // Thêm PictureBox để hiển thị ảnh
                PictureBox pictureBox = new PictureBox();
                pictureBox.Dock = DockStyle.Fill; // Phủ kín form con
                pictureBox.Image = Image.FromFile(openFileDialog.FileName); // Tải ảnh từ file
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Co giãn ảnh phù hợp với form

                // Thêm PictureBox vào form con
                childForm.Controls.Add(pictureBox);
                childForm.Text = openFileDialog.FileName; // Đặt tên form con bằng đường dẫn file
                childForm.Show(); // Hiển thị form con
            }
        }
    }
}

