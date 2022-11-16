using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab
{
    public partial class FrmGiaiTri : Form
    {
        
        public FrmGiaiTri()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            
            FrmQLPhim frmQLPhim = new FrmQLPhim(txt_name.Text);
            
            
      
            this.Hide();
            frmQLPhim.ShowDialog();
          
        }
    }
}
