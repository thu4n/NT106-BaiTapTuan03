using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;


namespace BaiTapTuan03
{
    class ServerSide
    {
        private int portNum;
        private string ipAdd;
        public ServerSide()
        {

        }
        public ServerSide(int port, string ip)
        {
            portNum = port;
            ipAdd = ip;
        }
        public void StartListen()
        {
            UdpClient listener = new UdpClient(portNum);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ipAdd), portNum);
            try
            {
                while (true)
                {

                }
            }
            catch(SocketException e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
