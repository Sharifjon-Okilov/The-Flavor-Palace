
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheFlavorPalace5
{
    public partial class Form1 : Form
    {

        private Server _server;
        private List<Cook> cooks;
        private int _eggCount;
        private int _chickenCount;
        private string _customerName;
        private int _counter = 0;
        private bool _isReceived = false;
        private bool _isSent = false;
        private bool _isPrepared = true;
        public Form1()
        {
            InitializeComponent();
            _server = new Server();
            cooks = new List<Cook> { new Cook() { Name = "Bob" }, new Cook() { Name = "Alex" } };
            // drinks.Items.AddRange(Enum.GetNames(typeof(Drinks)));
            drinks.DataSource = new Drink[] { new Tea(), new Coffee(), new Juice() };

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _counter++;
            _customerName = txtCustomerName.Text;
            _chickenCount = int.Parse(txtChickQuant.Text);
            _eggCount = int.Parse(txtEggQuant.Text);
            var drink = drinks.SelectedItem;
            Drink drink1 = (Drink)drink;
            _server.Receive(_customerName, _chickenCount, _eggCount, drink1);
            listBox.Items.Add(_counter + "-Order accepted.");
            _isReceived = true;


        }

        private void btnCopy_Click(object sender, EventArgs e)
        {

        }

        private void btnPrepare_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnSendRequest_Click(object sender, EventArgs e)
        {
            if (_isReceived)
            {
                TableRequest tableRequest = _server.GetTable();
                Cook cook = null;

                if (!cooks[0].IsAccepted)
                    cook = cooks[0];
                else if (!cooks[1].IsAccepted)
                    cook = cooks[1];
                List<string> result = await Task.Run(() =>
                {
                    tableRequest.IsAccepted = false;
                    cook.Process(tableRequest);
                }).ContinueWith(t => _server.Serve());

                foreach (var item in result)
                {
                    listBox.Items.Add(item + " From " + cook.Name);
                }
                listBox.Items.Add("Enjoy your meal!");
            }
            else
            {
                listBox.Items.Add("Not received from customer request!");
            }
            _isReceived = false;
        }

        private void btnServe_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
