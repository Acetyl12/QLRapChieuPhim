using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLRapChieuPhim.DSGhe;

namespace QLRapChieuPhim
{
    public partial class Form1 : Form
    {
        private float tongtien = 0;
        private string gioitinh = "Nam";
        private readonly BangGia _bangGia;
        private readonly DanhSachGhe DanhSachGhe = new DanhSachGhe();
        private readonly DSGheDaChon DSGheDaChon = new DSGheDaChon();
        private readonly DSGheDangChon dSGheDangChon = new DSGheDangChon();
        private readonly List<Button> buttonDangChon = new List<Button>();
        private readonly List<KhachHang> khachHangs = new List<KhachHang>();
        private readonly List<HoaDon> hoaDons = new List<HoaDon>();
        public Form1(BangGia bangGia)
        {
            InitializeComponent();
            _bangGia = bangGia;
            comboBox1.Items.Add("TpHCM");
            comboBox1.Items.Add("Biên Hòa - Đồng Nai");
            comboBox1.Items.Add("Cà Mau");
            comboBox1.Items.Add("Bạc Liêu");
            comboBox1.Items.Add("Hà Nội");
            comboBox1.SelectedIndex = 0;
            radioButton2.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnChonGhe_Click(object sender, EventArgs e)
        {
            Button btnSender = sender as Button;
            int soGhe = int.Parse(btnSender.Text) - 1;
            if (btnSender.BackColor == Color.PaleVioletRed)
            {
                MessageBox.Show("Không thể chọn ghế đã được chọn!!", "Thông báo", MessageBoxButtons.YesNo);
            }
            else if (!dSGheDangChon.IsAny(soGhe))
            {
                dSGheDangChon.ChonGhe(new Ghe(soGhe, soGhe));
                buttonDangChon.Add(btnSender);
                btnSender.BackColor = Color.LightGreen;
                tongtien += _bangGia[soGhe / 5];
            }
            else
            {
                dSGheDangChon.Remove(soGhe);
                buttonDangChon.RemoveAll(b => b.Text == btnSender.Text);
                btnSender.BackColor = Color.White;
                tongtien -= _bangGia[soGhe / 5];
            }

            label6.Text = tongtien.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string sdt = textBox2.Text;
            string khuvuc = comboBox1.Text;
            string gt = gioitinh;
            int keeptrack = 0;

            if (dSGheDangChon.Count() == 0)
            {
                MessageBox.Show("Hãy chọn một ghế!!!!", "Thông báo", MessageBoxButtons.YesNo);
                return;
            }

            if (string.IsNullOrEmpty(name) 
                || string.IsNullOrEmpty(sdt)
                || string.IsNullOrEmpty(khuvuc)
                || string.IsNullOrEmpty(gt))
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!!!!", "Thông báo", MessageBoxButtons.YesNo);
                return;
            }

            List<ChiTietHD> chiTietHDs = new List<ChiTietHD>();            

            foreach (var i in dSGheDangChon)
            {
                
                chiTietHDs.Add(new ChiTietHD(++keeptrack, i));
                DSGheDaChon.Chon(i);
            }

            KhachHang khachHang = new KhachHang(name, khuvuc, sdt);
            HoaDon hoaDon = new HoaDon(DateTime.Now, tongtien, khachHang);

            if (!khachHangs.Any(d => d.SDT == khachHang.SDT))
                khachHangs.Add(khachHang);
            else
            {
                MessageBox.Show("SDT đã tồn tại!!!!", "Thông báo", MessageBoxButtons.YesNo);
                return;
            }

            hoaDons.Add(hoaDon);

            foreach (var i in buttonDangChon)
            {
                i.BackColor = Color.PaleVioletRed;
            }

            dSGheDangChon.Clear();
            buttonDangChon.Clear();
            tongtien = 0;
            label6.Text = tongtien.ToString();
            data.Rows.Add(khachHang.MaKH, khachHang.HoTen, hoaDon.Ngay, hoaDon.Tien);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radiobox_click(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            gioitinh = radioButton.Text;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            foreach(Button t in buttonDangChon)
            {
                t.BackColor = Color.White;
            }
            dSGheDangChon.Clear();
            buttonDangChon.Clear();
            tongtien = 0;
            label6.Text = tongtien.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
