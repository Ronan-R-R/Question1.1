// using System;
// using System.Data;
// using System.Windows.Forms;

namespace MobileStockApp
{
    public partial class Form1 : Form
    {
        DataTable tbMobilePhones = new DataTable();

        public Form1()
        {
            InitializeComponent();

            tbMobilePhones.Columns.Add("MobileCode");
            tbMobilePhones.Columns.Add("Make");
            tbMobilePhones.Columns.Add("Quantity");
        }

        // ADD
        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbMobilePhones.Rows.Add(
                txtCode.Text,
                txtMake.Text,
                txtQuantity.Text
            );

            lblOutput.Text = "Record Added";
        }

        // DELETE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool found = false;

            foreach (DataRow row in tbMobilePhones.Rows)
            {
                if (row["MobileCode"].ToString() == txtCode.Text)
                {
                    tbMobilePhones.Rows.Remove(row);
                    lblOutput.Text = "Record Deleted";
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                lblOutput.Text = "Record NOT Found";
            }
        }

        // FIND
        private void btnFind_Click(object sender, EventArgs e)
        {
            bool found = false;

            foreach (DataRow row in tbMobilePhones.Rows)
            {
                if (row["MobileCode"].ToString() == txtCode.Text)
                {
                    txtMake.Text = row["Make"].ToString();
                    txtQuantity.Text = row["Quantity"].ToString();

                    lblOutput.Text = "Record Found";
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                lblOutput.Text = "Record NOT Found";
            }
        }
    }
}