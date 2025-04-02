using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medicamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void IconBtn1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void IconBtn2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gerenciarMedicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();
        }
    }
}
