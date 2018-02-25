using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeFrame
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void loading_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(200);
            frm_startup frm = new frm_startup();
            frm.Show();
           
            
            
            //loading_load.Dipose();
            this.Hide();

        }
    }


}
