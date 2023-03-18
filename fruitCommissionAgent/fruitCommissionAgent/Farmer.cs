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
using System.Xml.Linq;

namespace fruitCommissionAgent
{
    public partial class Farmer : Form
    {
        public Farmer()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection();
        int ID;
        int rowID;
        private object dgvFarmer;

        private void Farmer_Load(object sender, EventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlCommand cmd = new SqlCommand("Select * from farmer", con);
            cmd.Connection = con;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            //dgvFarmer.DataSource = ds.Tables[0];
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

                    MessageBox.Show("Farmer Data Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void fruitCommissionAgent_Load(Farmer farmer, object value)
        {
            throw new NotImplementedException();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
          //  SqlCommand cmd = new SqlCommand("Insert into farmer values(@bewfariName,@mobileNumber,@address,@city,@province)", con);

            //SQLParameter collection
            con.Open();
            cmd.Parameters.AddWithValue("@bewfariName", txtBewfariName.Text);
            cmd.Parameters.AddWithValue("@mobileNumber", txtMobileNumber.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@city", txtCity.Text);
            cmd.Parameters.AddWithValue("@province", txtProvince.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            //MessageBox.Show("You have successfully added data.", "Heading", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            MessageBox.Show("Farmer record added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
          //  SqlCommand cmd = new SqlCommand("Update employee set empName=@empName,empPhone=@empPhone,empEmail=@empEmail,empAddress=@empAddress,empPosition=@empPosition where empID= '" + ID + "'", con);
            con.Open();

            cmd.Parameters.AddWithValue("@bewfariName", txtBewfariName.Text);
            cmd.Parameters.AddWithValue("@mobileNumber", txtMobileNumber.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@city", txtCity.Text);
            cmd.Parameters.AddWithValue("@province", txtProvince.Text);

            //cmd.Parameters.AddWithValue("@stulivingstatus", cbLivingStatus.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Farmer record updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Farmer_Load(this, null);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            throw new NotImplementedException();
        }
    }

  

        

       
    
}
