﻿using System;
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
    public partial class Truck : Form
    {
        public Truck()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlCommand cmd = new SqlCommand("Insert into farmer values(@tradeNumber,@arrivalTime,@truckNumber,@rent,@search)", con);

            //SQLParameter collection
            con.Open();
            cmd.Parameters.AddWithValue("@tradeNumber", txtTradeNumber.Text);
            cmd.Parameters.AddWithValue("@arrivalTime", txtArrivalTime.Text);
            cmd.Parameters.AddWithValue("@truckNumber", txtTruckNumber.Text);
            cmd.Parameters.AddWithValue("@rent", txtRent.Text);
            cmd.Parameters.AddWithValue("@search", txtSearch.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            //MessageBox.Show("You have successfully added data.", "Heading", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            MessageBox.Show("Farmer record added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlCommand cmd = new SqlCommand("Insert into farmer values(@tradeNumber,@arrivalTime,@truckNumber,@rent,@search)", con);

            //SQLParameter collection
            con.Open();
            cmd.Parameters.AddWithValue("@tradeNumber", txtTradeNumber.Text);
            cmd.Parameters.AddWithValue("@arrivalTime", txtArrivalTime.Text);
            cmd.Parameters.AddWithValue("@truckNumber", txtTruckNumber.Text);
            cmd.Parameters.AddWithValue("@rent", txtRent.Text);
            cmd.Parameters.AddWithValue("@search", txtSearch.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            //MessageBox.Show("You have successfully added data.", "Heading", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            MessageBox.Show("Farmer record updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void fruitCommissionAgent_Load(Truck truck, object value)
        {
            throw new NotImplementedException();
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
