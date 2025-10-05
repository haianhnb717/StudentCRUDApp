using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace StudentCRUDApp
{
    public partial class Form1 : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["StudentDB"].ConnectionString;

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
            using (Microsoft.Data.SqlClient.SqlConnection conn = new Microsoft.Data.SqlClient.SqlConnection(connStr))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvStudents.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (Microsoft.Data.SqlClient.SqlConnection conn = new Microsoft.Data.SqlClient.SqlConnection(connStr))
            {
                conn.Open();
                string sql = "INSERT INTO Students (StudentCode, StudentName, BirthDate) VALUES (@code, @name, @birth)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@code", txtCode.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@birth", DateTime.Parse(txtBirthDate.Text));
                cmd.ExecuteNonQuery();
            }
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvStudents.CurrentRow.Cells["StudentID"].Value);

            using (Microsoft.Data.SqlClient.SqlConnection conn = new Microsoft.Data.SqlClient.SqlConnection(connStr))
            {
                conn.Open();
                string sql = "UPDATE Students SET StudentCode=@code, StudentName=@name, BirthDate=@birth WHERE StudentID=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@code", txtCode.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@birth", DateTime.Parse(txtBirthDate.Text));
                cmd.ExecuteNonQuery();
            }
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvStudents.CurrentRow.Cells["StudentID"].Value);

            using (Microsoft.Data.SqlClient.SqlConnection conn = new Microsoft.Data.SqlClient.SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Students WHERE StudentID=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            LoadData();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCode.Text = dgvStudents.Rows[e.RowIndex].Cells["StudentCode"].Value.ToString();
                txtName.Text = dgvStudents.Rows[e.RowIndex].Cells["StudentName"].Value.ToString();
                txtBirthDate.Text = Convert.ToDateTime(dgvStudents.Rows[e.RowIndex].Cells["BirthDate"].Value).ToShortDateString();
            }
        }
    }
}