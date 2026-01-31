using System;
using System.Windows.Forms;

namespace Ass1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xin chào");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void btnBye_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tạm biệt");
        }

    }
}
