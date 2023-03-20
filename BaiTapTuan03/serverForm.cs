using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace BaiTapTuan03
{
    public partial class serverForm : Form
    {
        public serverForm()
        {
            InitializeComponent();
            Text = "Server side of Steam Chat";
        }

        private void serverForm_Load(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            int portNum = Int32.Parse(serverPortTB.Text);
            string ipadd = ipTextBox.Text;
        }
        private void serverPortTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ipTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    
    }
}
