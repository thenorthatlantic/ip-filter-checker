using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace ipfilterchecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static async Task<bool> IsPortOpenAsync(string ipAddress, int port, int timeout)
        {
            try
            {
                using (var client = new TcpClient())
                {
                    var connectTask = client.ConnectAsync(ipAddress, port);
                    await Task.WhenAny(connectTask, Task.Delay(timeout));
                    if (connectTask.IsCompleted && client.Connected)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }


        private async void button1_Click(object sender, EventArgs e)
        {
           label3.Text = string.Empty;
           if (await IsPortOpenAsync(textBox1.Text, Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value)))
            {
                label3.ForeColor = Color.Green;
                label3.Text = "Not filtered";
            }
            else
            {
                label3.ForeColor = Color.Red;
                label3.Text = "filtered";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/thenorthatlantic/ip-filter-checker#%D9%86%D8%AD%D9%88%D9%87-%D8%A7%D8%B3%D8%AA%D9%81%D8%A7%D8%AF%D9%87");
        }
    }
}
