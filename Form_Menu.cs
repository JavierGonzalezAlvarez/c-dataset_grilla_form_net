using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }


        private void From_Menu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        
        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
                        
            Form_DataSet Form_hijo = new Form_DataSet();
            Form_hijo.MdiParent = this;
            Form_hijo.Show();
        }
    }
}
