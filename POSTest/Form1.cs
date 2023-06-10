using System.Security.Cryptography;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System;
using System.Data.OleDb;
using System.Data;

namespace POSTest
{

    public partial class Form1 : Form
    {
       SqlCommand cmd=new SqlCommand();
        //SqlConnection Con = new SqlConnection("@Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\WayyaBro\Documents\POSDBTest.mdf;Integrated Security = True; Connect Timeout = 30");

        //for encryption of text
        static string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data=md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
           // OleDbConnection conn = new OleDbConnection("@Provider =.NET Framework Data Provider for SQL Server;Data Source=C:\\USERS\\WAYYABRO\\DOCUMENTS\\POSDBTEST.MDF");
           // OleDbDataAdapter da = new OleDbDataAdapter("Select EName from EmployeeTable", conn);
            //DataSet dt= new DataSet();
           // da.Fill(dt,"EmployeeTable");
           // comboBox1.DataSource= dt.Tables["EmployeeTable"];
            //comboBox1.DisplayMember= "EName";
            comboBox1.Text = "Select User";
        }
        
        private void CBShow_CheckedChanged(object sender, EventArgs e)
        {
            if(CBShow.Checked == true) 
            {
                PasswordTb.UseSystemPasswordChar= false;
            }
            else
            {
                PasswordTb.UseSystemPasswordChar= true;
            }
           
        }

        private void BttnLogIn_Click(object sender, EventArgs e)
        {
            if(PasswordTb.Text=="")
            {
                MessageBox.Show("Please Enter Password");
            }
            if (comboBox1.Text == "Select User")
            {
                MessageBox.Show("please Enter an User");
            }

        }
    }
}