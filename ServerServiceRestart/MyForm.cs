using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerServiceRestart
{
    public partial class FrmServerrestart : Form
    {
        public FrmServerrestart()
        {
            InitializeComponent();
        }

       
        private void ServerNametext_TextChanged(object sender, EventArgs e)
        {

        }

        private void MyForm_Load(object sender, EventArgs e)
        {

        }

        private void ServerListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MyForm_Load_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GetServerStatus(object sender, EventArgs e)
        {
            lblServerStatus.Text =  lstServerList.SelectedItem.ToString()+" is up and running";
            lblServerStatus.Visible = true;
        }

        private void btnGetServices(object sender, EventArgs e)
        {
            List<string> Services;
            if (lstServerList.SelectedIndex >= 0)
            {
                string ServerName = lstServerList.SelectedItem.ToString();
                //MessageBox.Show(" Server Name= "+ServerName);
                Services = Getservices(ServerName);
                //MessageBox.Show("Services Count " + Services.Count);

                CheckBox box;
                Label lbl;
                for (int i = 0; i < Services.Count; i++)
                {
                    box = new CheckBox();
                    lbl = new Label();
                    box.Tag = i.ToString();
                    lbl.Tag = i.ToString();
                    box.Text = Services[i] + " Status ";
                    lbl.Text = Services[i] + " is running";
                    box.AutoSize = true;
                    lbl.AutoSize = true;
                    lbl.Visible = true;
                    box.Location = new Point(400, (i+3) * 35); //vertical
                    lbl.Location = new Point(600, (i + 3) * 35);
                    //box.Location = new Point(i * 50, 10); //horizontal
                    this.Controls.Add(box);
                    this.Controls.Add(lbl);
                }
                //test
            }
            else
            {
                MessageBox.Show("Please select an item!!");
            }
        }

        private List<string> Getservices(string servername)
        {
            List<string> list = new List<string>();

            switch (servername.ToLower())
            {
                case "server 1":
                    Console.WriteLine("Service 1");
                    list.Add("Service 1");
                    break;
                case "server 2":
                    Console.WriteLine("Server 2");
                    list.Add("Service 1");
                    list.Add("Service 2");
                    break;
                case "server 3":
                    Console.WriteLine("Server 3");
                    list.Add("Service 1");
                    list.Add("Service 2");
                    list.Add("Service 3");
                    break;
                case "server 4":
                    Console.WriteLine("Service 4");
                    list.Add("Service 1");
                    list.Add("Service 2");
                    list.Add("Service 3");
                    list.Add("Service 4");
                    break;
                case "server 5":
                    Console.WriteLine("Server 5");
                    list.Add("Service 1");
                    list.Add("Service 2");
                    list.Add("Service 3");
                    list.Add("Service 4");
                    list.Add("Service 5");
                    break;
                default:
                    Console.WriteLine("Invalid Service");
                    break;
            }
            return list;
        }

    }
}
