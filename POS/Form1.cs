using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double Cost_of_Items()
        {
            double sum = 0;
            int i = 0;

            for (i = 0; i < (dataGridView1.Rows.Count); 
                i++)
                
            {
                sum = sum + Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
            }
            return sum;
        }

        private void AddCost()
        {
            Double tax, q;
            tax = 3.9;
            if (dataGridView1.Rows.Count > 0)
            {
                lblTax.Text = String.Format("PHP", (((Cost_of_Items() * tax) / 100)));
                lblSubTotal.Text = String.Format("PHP", (Cost_of_Items()));
                q = ((Cost_of_Items() * tax) / 100);
                lblTotal.Text = String.Format("PHP", (Cost_of_Items() + q));
                lblBarCode.Text = Convert.ToString(q + Cost_of_Items());
            }

        }

        private void Change()
        {
            Double tax, q, c;
            tax = 3.9;
            if (dataGridView1.Rows.Count > 0)
            {
                q = ((Cost_of_Items() * tax) / 100) + Cost_of_Items();
                c = Convert.ToInt32(lblCash.Text);
                lblChange.Text = String.Format("PHP", c - q);
            }
        }  


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblBarCode_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        Bitmap bitmap;

        private void button30_Click(object sender, EventArgs e)
        {
            try
            {
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            dataGridView1.Height = height;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawImage(bitmap, 0, 0);
            }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void button31_Click(object sender, EventArgs e)
        {
            try
            {
                lblBarCode.Text = "";
                lblCash.Text = "0";
                lblChange.Text = "";
                lblSubTotal.Text = "";
                lblTax.Text = "";
                lblTotal.Text = "";
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                cboPayment.Text = "";

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           cboPayment.Items.Add("Cash");
           cboPayment.Items.Add("Visa Card");
           cboPayment.Items.Add("Master Card");
        }

        private void NumbersOnly(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (lblCash.Text == "0")
            {
                lblCash.Text = "";
                lblCash.Text = b.Text;
            }
            else if (b.Text == ".")
            {
                if (! lblCash.Text.Contains("."))
                {
                    lblCash.Text = lblCash.Text + b.Text;
                }

            }
            else
            
                lblCash.Text = lblCash.Text + b.Text;
            

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            lblCash.Text = "0";
        }

        private void Pay_Click(object sender, EventArgs e)
        {
            if(cboPayment.Text == "Cash")
            {
                Change();
            }
            else
            {
                lblChange.Text = "";
                lblCash.Text = "0";
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                    dataGridView1.Rows.Remove(row);
            }
            AddCost();
        }
    }
}
