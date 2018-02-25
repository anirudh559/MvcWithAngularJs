using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApiService.Models
{
    public class Customer
    {


        public DataTable GetCustomerData()
        {
            string connstring = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            SqlConnection conString = new SqlConnection(connstring);
            conString.Open();
            SqlCommand cmdQuery = new SqlCommand("select * from customer", conString);
            SqlDataAdapter sda = new SqlDataAdapter(cmdQuery);
            DataTable dsData = new DataTable();
            sda.Fill(dsData);
            return dsData;
        }  



        //SqlConnection conn= new SqlConnection();
        //SqlCommand comm;
        //SqlDataReader dreader;
        //
        ////conn = new SqlConnection(connstring);
        //    conn.Open();
        //    comm = new SqlCommand("insert into student_detail values(" + txtrn.Text + ",'" + txtname.Text + "'," + txtage.Text + ",'" + txtcourse.Text + "')", conn);
    }


}