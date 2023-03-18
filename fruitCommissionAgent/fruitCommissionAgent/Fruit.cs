using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fruitCommissionAgent
{
    public partial class Fruit : Form
    {
        public object con;
        public object txtBewfruitName;
        public object cmd;

        public Fruit()
        {
            InitializeComponent();
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
          //  con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlCommand cmd = new SqlCommand("Insert into farmer values(@bewfariName,@mobileNumber,@address,@city,@province)", con);
            //SQLParameter collection
            con.Open();
            cmd.Parameters.AddWithValue("@bewfariName", txtFruitName.Text);
           // cmd.Parameters.AddWithValue("@mobileNumber", txtMobileNumber.Text);
           // cmd.Parameters.AddWithValue("@address", txtAddress.Text);
           // cmd.Parameters.AddWithValue("@city", txtCity.Text);
           // cmd.Parameters.AddWithValue("@province", txtProvince.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("fruitCommissionAgent record added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            fruitCommissionAgent_Load(this, null);
            clear();
        }

        private void clear()
        {
            throw new NotImplementedException();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@bewfariName", txtFruitName.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("fruitCommissionAgent record updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fruitCommissionAgent_Load(this, null);
        }

        private void fruitCommissionAgent_Load(Fruit fruit, object value)
        {
            throw new NotImplementedException();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete the selected record?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                    //SqlCommand cmd = new SqlCommand("Delete from employee where empID='" + ID + "'");
                    //cmd.Connection = con;

                    MessageBox.Show("Employee Data Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

//                    DataSet ds = new DataSet();
                   // sda.Fill(ds);
                    fruitCommissionAgent_Load(this, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll()
        {
            throw new NotImplementedException();
        }
    }
}
