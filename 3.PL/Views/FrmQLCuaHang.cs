
using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmQLCuaHang : Form
    {
        private IQLCuaHangService _Ichs;
        private Guid _idclick;

        public FrmQLCuaHang()
        {
            InitializeComponent();
            _Ichs = new QLCuaHangService();
            loadfrm();
        }
        public void loadfrm()
        {
            int stt = 1;
            Type type = typeof(CuaHang);
            dgrid_qlch.ColumnCount = 8;//Hiển thị bao nhiểu cột tự cấu hình
            dgrid_qlch.Columns[0].Name = "STT";
            dgrid_qlch.Columns[1].Name = "MÃ";
            dgrid_qlch.Columns[2].Name = "Tên";
            dgrid_qlch.Columns[3].Name = "Địa Chỉ";
            dgrid_qlch.Columns[4].Name = "Thành Phố";
            dgrid_qlch.Columns[5].Name = "Quốc Gia";
           
            dgrid_qlch.Rows.Clear();

            foreach (var x in _Ichs.CHGetAll())
            {
                dgrid_qlch.Rows.Add(stt++, x.Ma, x.Ten, x.DiaChi, x.ThanhPho, x.QuocGia);
            }
        }
        public CuaHang Getfrm()
        {
            return new CuaHang()
            {
                Ma=txt_ma.Text,
                Ten=txt_ten.Text,
                DiaChi=txt_diachi.Text,
                ThanhPho=txt_TP.Text,
                QuocGia=txt_QG.Text
                
            };
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_Ichs.Add(Getfrm()));
            loadfrm();
        }
    }     
    }

