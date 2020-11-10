using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Exercises_100_2018
{
    public partial class PullDataFromDatabase : Form
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FacultyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public PullDataFromDatabase()
        {
            InitializeComponent();
        }

        private void PullDataFromDatabase_Load(object sender, EventArgs e)
        {
            //kacenje na bazu podataka i prikaz podataka iz tabele Students
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                List<ExerciseClass> lista = new List<ExerciseClass>();
                conn.Open();
                SqlCommand komanda = new SqlCommand();
                komanda.Connection = conn;
                komanda.CommandText = "SELECT * FROM ExerciseTable";
                SqlDataReader dr = komanda.ExecuteReader();
                while (dr.Read())
                {
                    ExerciseClass exercise = new ExerciseClass();
                    exercise.id = dr.GetInt32(0);
                    exercise.StudentName = dr.GetString(1);
                    exercise.StudentIndex = dr.GetString(2);
                    exercise.Points = dr.GetInt32(3);
                    lista.Add(exercise);

                }
                 conn.Close();
                foreach (ExerciseClass s in lista)
                {
                    listboxPrintData.Items.Add(s.id + ", " + s.StudentName + ", " + s.StudentIndex + ", " + s.Points);
                }
            }
        }
    }
}
