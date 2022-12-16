using AdoNetDesktop.Constants;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AdoNetDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(UrlConstants.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Select * from Students", conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = cmd;
                        using (DataSet ds = new DataSet())
                        {
                            da.Fill(ds);
                            UserListDGRView.DataSource = ds.Tables[0];
                        }
                    }
                }
            }
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(UrlConstants.ConnectionString))
            {
                conn.Open();
                string name = NameTxt.Text;
                string surname = SurnameTxt.Text;
                int age = (int)AgeValue.Value;
                using (SqlCommand cmd = new SqlCommand("Insert into Students values(@name,@surname,@age)", conn))
                {
                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("surname", surname);
                cmd.Parameters.AddWithValue("age", age);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadData();
            ClearTexts();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(UrlConstants.ConnectionString))
            {
                conn.Open();
                int id = (int)UserListDGRView.CurrentRow.Cells["Id"].Value;
                using (SqlCommand cmd = new SqlCommand("Delete from Students where id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("id", id);                   
                    cmd.ExecuteNonQuery();
                }
            }
            LoadData();
            ClearTexts();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(UrlConstants.ConnectionString))
            {
                conn.Open();
                string name = NameTxt.Text;
                string surname = SurnameTxt.Text;
                int age = (int)AgeValue.Value;
                int id = (int)UserListDGRView.CurrentRow.Cells["Id"].Value;
                using (SqlCommand cmd = new SqlCommand("Update Students Set Name=@name,Surname=@surname,Age=@age where id =@id", conn))
                {
                    cmd.Parameters.AddWithValue("name", name);
                    cmd.Parameters.AddWithValue("surname", surname);
                    cmd.Parameters.AddWithValue("age", age);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadData();
            ClearTexts();
        }

        private void ClearTexts()
        {
            NameTxt.Text = string.Empty;
            SurnameTxt.Text= string.Empty;
            AgeValue.Value = 0;
        }

        private void UserListDGRView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserListDGRView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = (string)UserListDGRView.CurrentRow.Cells["Name"].Value;
            string surname = (string)UserListDGRView.CurrentRow.Cells["Surname"].Value;
            int age = (int)UserListDGRView.CurrentRow.Cells["Age"].Value;
            NameTxt.Text = name;
            SurnameTxt.Text = surname;
            AgeValue.Value = age;
        }
    }
}
