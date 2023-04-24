using QuanLyNhanSu.BUS_Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class regime : Form
    {
        BUS_CheDo ds;
        public regime()
        {
            InitializeComponent();
            ds = new BUS_CheDo();
        }

      
        public void load()
        {
            dg_CheDo.DataSource = null;
            ds.getCheDo(dg_CheDo);

            dg_CheDo.Columns[0].Width = (int)(dg_CheDo.Width * 0.1);
            dg_CheDo.Columns[1].Width = (int)(dg_CheDo.Width * 0.1);
            dg_CheDo.Columns[2].Width = (int)(dg_CheDo.Width * 0.2);
            dg_CheDo.Columns[3].Width = (int)(dg_CheDo.Width * 0.1);
            dg_CheDo.Columns[4].Width = (int)(dg_CheDo.Width * 0.3);
            dg_CheDo.Columns[5].Width = (int)(dg_CheDo.Width * 0.2);


        }
        private void regime_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
