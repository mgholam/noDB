using fastJSON;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Linq.Dynamic;

namespace datagridbinding
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private List<SalesInvoice> _list = new List<SalesInvoice>();
        private string _filename = "data.json";

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DoubleBuffered(true);

            // if data !exists -> create 
            if (File.Exists(_filename))
                _list = JSON.ToObject<List<SalesInvoice>>(File.ReadAllText(_filename));
            else
            {
                for (int i = 0; i < 100000; i++)
                    _list.Add(CreateInvoice(i));

                var jp = new JSONParameters
                {
                    UseEscapedUnicode = false,
                    UseFastGuid = false,
                    UseExtensions = false,
                    EnableAnonymousTypes = true
                };
                File.WriteAllText(_filename, JSON.ToNiceJSON(_list, jp));
            }
            GC.Collect();
            Query();
        }

        void TextBox1KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                Query();
        }

        private void Query()
        {
            try
            {
                DateTime dt = DateTime.Now;
                var q = _list.AsQueryable();
                var qry = textBox1.Text.Trim();
                int c = _list.Count;
                if (qry != "")
                {
                    var result = q.Where(qry);
                    bindingSource1.DataSource = result;
                    c = result.Count();
                }
                else
                    bindingSource1.DataSource = _list;

                toolStripStatusLabel2.Text = "Query time (ms) = " + DateTime.Now.Subtract(dt).TotalMilliseconds;
                dataGridView1.DataSource = bindingSource1;
                toolStripStatusLabel1.Text = "Count = " + c.ToString("#,0");
                stsError.Text = "";
            }
            catch (Exception ex)
            {
                stsError.Text = ex.Message;
                dataGridView1.DataSource = null;
                toolStripStatusLabel1.Text = "Count = 0";
                toolStripStatusLabel2.Text = "Query time (ms) = 0";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static SalesInvoice CreateInvoice(int i)
        {
            var inv = new SalesInvoice()
            {
                Date = Faker.DateTimeFaker.BirthDay(),
                Serial = i % 10000,
                Name = Faker.NameFaker.Name(),
                Company = Faker.CompanyFaker.Name(),//  "Me " + i % 10,
                Status = (byte)(i % 4),
                Address = Faker.LocationFaker.Street(), //"df asd sdf asdf asdf",
                Approved = i % 100 == 0 ? true : false
            };
            //inv.Items = new List<LineItem>();
            //for (int k = 0; k < 5; k++)
            //    inv.Items.Add(new LineItem() { Product = "prod " + k, Discount = 0, Price = 10 + k, QTY = 1 + k });
            return inv;
        }

        private void sample1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "name= 'oat' and address = 'birch'".Replace("'", "\"");
            Query();
        }

        private void sample2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "date.year > 2000 and date.month = 4 && address = 'hill'".Replace("'", "\"");
            Query();
        }

        private void sample3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "approved = true and address = 'hill'".Replace("'", "\"");
            Query();
        }

        private void sample4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "(address = 'hill' or address = 'oak') and status = 2".Replace("'", "\"");
            Query();
        }

        private void sample5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "date.year % 2 = 0";
            Query();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var l = new List<SalesInvoice>();

            l.Add(new SalesInvoice
            {
                Address = "a"
            });
            l.Add(new SalesInvoice
            {
                Name = "b"
            });
            l.Add(new SalesInvoice
            {
                Name = "a"
            });

            var a = l.Where("name != 'a'".Replace("'", "\""));
            var i = a.Count();
        }
    }
}