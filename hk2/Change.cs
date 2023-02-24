using hk2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hk2
{
    public partial class Change : Form
    {
        public Change()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new ContactsModel();
            var list = context.Table.Where(x => x.Product_Id == textBox1.Text).ToList();
            foreach (var item in list)
            {
                context.Table.Remove(item);
            }
            context.SaveChanges();

            Table datas = new Table()
            {
                Product_Id = textBox1.Text.Trim(),
                Product_Name = textBox2.Text.Trim(),
                Product_Amount = Convert.ToInt32(textBox3.Text.Trim()),
                Product_Price = Convert.ToInt32(textBox4.Text.Trim()),
                Product_Class = textBox5.Text.Trim()

            };
            try
            {
                //ContactsModel context = new ContactsModel();
                context.Table.Add(datas);
                context.SaveChanges();
                MessageBox.Show("修改完成");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤 {ex.ToString()}");
            }


        }

        private void Change_Load(object sender, EventArgs e)
        {

        }
    }
}
