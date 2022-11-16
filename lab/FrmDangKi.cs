
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace lab
{
    public partial class FrmDangKi : Form
    {

        public FrmDangKi()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
           
            var kt = new Regex("^[a-zA-Z0-9 ]{2,}$");

            if (txt_TK.Text == "ph20877" && txt_MK.Text == "123456")
            {
                FrmQLPhim frmQLPhim = new FrmQLPhim(txt_TK.Text, txt_MK.Text);
                this.Hide();
                frmQLPhim.ShowDialog();

            }
            else if (kt.IsMatch(txt_MK.Text)==true && kt.IsMatch(txt_TK.Text)==true)
            {
                MessageBox.Show("Chưa nhập đúng");
               
            }
            else 
            {
                MessageBox.Show("Không được chứa kí tự đặc biệt hoặc độ dài ít hơn 2 kí tự ");
                txt_MK.Clear();
                txt_TK.Clear();
            }
        }

        private void txt_TK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
