using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortScanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            dataGridView1.Rows.Clear();
            button1.Enabled = false;
            PortScanner ps = new PortScanner(
                txtIp.Text, 
                int.Parse(txtStartPort.Text), 
                int.Parse(txtEndPort.Text),
                int.Parse(txtTcpTimeout.Text),
                dataGridView1,
                txtCurrentPort,
                this,button1);
            ps.start();
        }

        private void txtIp_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
