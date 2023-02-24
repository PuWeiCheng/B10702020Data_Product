using hk2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hk2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form =new ViewForm();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var readText = File.ReadAllLines("C:\\Users\\wayne\\source\\repos\\product.csv").Skip(1).ToList();
            var context = new ContactsModel();
            var list_all =context.Table.ToList();
            foreach(var row in list_all.ToList())
            {
                context.Table.Remove(row);
            }
            foreach (var row in readText)
            {
                string[] values = row.Split(',');

                Table data = new Table()
                {
                    Product_Id = values[0],
                    Product_Name = values[1],
                    Product_Amount = Convert.ToInt32(values[2]),
                    Product_Price = Convert.ToInt32(values[3]),
                    Product_Class = values[4]

                };
                context.Table.Add(data);
            }
            context.SaveChanges();
            MessageBox.Show("設定完成");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new AddForm();
            form.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = new Delete();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form = new Change();
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var form = new Search();
            form.ShowDialog();
        }
    }
}
