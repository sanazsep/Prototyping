using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labb_1_Agilametoder_SUW
{
    public partial class Form1 : Form
    {
        List<String> AddressList = new List<string>();
        public Form1()
        {
            InitializeComponent();
            //Information about each objects
            AddressList.Add("Name\tE-mail\tNumber");
            AddressList.Add("Bengt\tbenga55@gmail.com\t0701234567");
            AddressList.Add("Peter\tptr@hotspot.com\t0701234576");
            AddressList.Add("Lina\tlina_w@gmail.com\t0701239654");
            AddressList.Add("Ahmed\tahmed_ahmed@gmail.com\t0707654321");
            AddressList.Add("Angelica\tangelangelica@gmail.com\t0701212125");
            AddressList.Add("Olof\tolof_olofsson5@gmail.com\t0702223336");
            AddressList.Add("Clara\tstensson_c@gmail.com\t0730456789");
            AddressList.Add("Stina\tstinastinastinastina@hotmail.com\t0700554412");
            AddressList.Add("Bertil\tberitochbertil@telia.com\t0700000258");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddressList.Add(textBox1.Text +"     "+ textBox2.Text + "     "+ textBox3.Text);
            Stuff();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;while(i < AddressList.Count)
            {
                listBox1.Items.Add(AddressList.ElementAt(i));i++;
            }
            Stuff();
        }
        //This is stuff needs to change, rename it
        private void Stuff()
        {
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
        }
        //det här är en knapp
        private void button3_Click(object sender, EventArgs e)
        {

            string str = textBox4.Text;int i = 0;
            while (i < AddressList.Count)
            {if (AddressList.ElementAt(i).Contains(str)){    MessageBox.Show("Hittade: " + AddressList.ElementAt(i)); i++;}else
                {MessageBox.Show("Nope"); i++; }}
        }
    }
}
