using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortScanner
{
    class PortScanner
    {

        private string host;
        private PortList portList;
        private bool turnOff = true;
        private int count = 0;
        public int tcpTimeout;
        private DataGridView view;
        ToolStripProgressBar CurrentPortCount;
        Form f;
        Button button1;
        private class isTcpPortOpen
        {
            public TcpClient MainClient { get; set; }
            public bool tcpOpen { get; set; }
        }


        public PortScanner(
            string host, int portStart, int portStop,
            int timeout, DataGridView Gview, ToolStripProgressBar CurrentPortCount,
            Form t,Button button1)
        {
            this.host = host;
            portList = new PortList(portStart, portStop);
            tcpTimeout = timeout;
            view = Gview;
            this.CurrentPortCount = CurrentPortCount;
            f = t;
            this.button1 = button1;
        }

        public void start()
        {
            CurrentPortCount.Minimum = portList.start;
            CurrentPortCount.Maximum = portList.stop;
            new Task(() => {
                Parallel.For(portList.start, portList.stop, (i) => {
                    try
                    {
                        Connect(host, i, tcpTimeout);
                    }
                    catch
                    {
                        f.BeginInvoke((Action)(() =>
                        {
                            view.Rows.Add(i, "Close", "");
                            CurrentPortCount.PerformStep();
                        }));
                        if (this.CurrentPortCount.Value >= this.CurrentPortCount.Maximum - 1)
                        {
                            f.BeginInvoke((Action)(() =>
                            {
                                button1.Enabled = true;
                                CurrentPortCount.Value = CurrentPortCount.Minimum;
                            }));
                        }
                        return;
                    }
                    int Data1 = i;
                    string Data2 = "Open";
                    string Data3 = string.Empty;
                    try
                    {
                        Data3 = BannerGrab(host, i, tcpTimeout);
                    }
                    catch (Exception ex)
                    {
                        Data3 = "Could not retrieve the Banner ::Original Error = " + ex.Message;
                    }

                    f.BeginInvoke((Action)(() =>
                    {
                        view.Rows.Add(Data1, Data2, Data3);
                        CurrentPortCount.PerformStep();
                    }));

                    if (this.CurrentPortCount.Value >= this.CurrentPortCount.Maximum - 1)
                    {
                        f.BeginInvoke((Action)(() =>
                        {
                            button1.Enabled = true;
                            CurrentPortCount.Value = CurrentPortCount.Minimum;
                        }));
                    }
                });

            }).Start();

        } 
        
        //method for returning tcp client connected or not connected
        public TcpClient Connect(string hostName, int port, int timeout)
        {
            var newClient = new TcpClient();

            var state = new isTcpPortOpen
            {
                MainClient = newClient,
                tcpOpen = true
            };

            IAsyncResult ar = newClient.BeginConnect(hostName, port, AsyncCallback, state);
            state.tcpOpen = ar.AsyncWaitHandle.WaitOne(timeout, false);

            if (state.tcpOpen == false || newClient.Connected == false)
            {
                throw new Exception();

            }
            return newClient;
        }

        //method for Grabbing a webpage banner / header information
        public string BannerGrab(string hostName, int port, int timeout)
        {
            var newClient = new TcpClient(hostName, port);


            newClient.SendTimeout = timeout;
            newClient.ReceiveTimeout = timeout;
            NetworkStream ns = newClient.GetStream();
            StreamWriter sw = new StreamWriter(ns);

            //sw.Write("GET / HTTP/1.1\r\n\r\n");

            sw.Write("HEAD / HTTP/1.1\r\n\r\n"
                + "Connection: Closernrn");

            sw.Flush();

            byte[] bytes = new byte[2048];
            int bytesRead = ns.Read(bytes, 0, bytes.Length);
            string response = Encoding.ASCII.GetString(bytes, 0, bytesRead);

            return response;
        }


        //async callback for tcp clients
        void AsyncCallback(IAsyncResult asyncResult)
        {
            var state = (isTcpPortOpen)asyncResult.AsyncState;
            TcpClient client = state.MainClient;

            try
            {
                client.EndConnect(asyncResult);
            }
            catch
            {
                return;
            }

            if (client.Connected && state.tcpOpen)
            {
                return;
            }

            client.Close();
        }
    }
}
