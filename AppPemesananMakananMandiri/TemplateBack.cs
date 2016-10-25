using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPemesananMakananMandiri
{
    public partial class TemplateBack : Form
    {
            public TemplateBack()
            {
                InitializeComponent();
            }

            private void pictureBox1_Click(object sender, EventArgs e)
            {

            }

            private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
            {

            }

            private void TemplateBack_Load(object sender, EventArgs e)
            {

            }

            private void tabPage2_Click(object sender, EventArgs e)
            {
                FormTambahMenu ftm = new FormTambahMenu();
                ftm.ShowDialog();
                ftm.Focus();
            }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
