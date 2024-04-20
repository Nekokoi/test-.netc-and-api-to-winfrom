using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testquadra
{
    public partial class mainuser : Form
    {
        public mainuser()
        {
            InitializeComponent();
        }

        private void ขอมลโดยรวมToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewdata paslogin = new viewdata();
            this.panel1.Controls.Clear();
            paslogin.TopLevel = false;
            paslogin.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(paslogin);
            paslogin.Show();
        }
    }
}
