using AdoNet_ORM.DAL;
using AdoNet_ORM.Models;
using System.Data;
using System.Data.SqlClient;

namespace AdoNet_ORM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetName(4);
            //InsertStudent("Ilqar", "Niftaliyev");
            //GetAllStudents();

            //Student student = new Student() { Name="Zahid",SurName="Mammadov",Age=22};
            //AddStudentWithEF(student);
            //GetAllStudentsWithEF();
            GetStudentsWithEF(3);
            Console.ReadLine();

        }
        static string ConnectionString = @"Server=DESKTOP-QBQM5QA\SQLEXPRESS;Database=BB202;Trusted_Connection=True;";
        public static async void GetName(int id)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Select name from OldStudents where id=@id", conn))
                {
                    //cmd.Parameters.AddWithValue("id",id);
                    cmd.Parameters.AddWithValue("id", SqlDbType.Int).Value = id;
                    string name = (await cmd.ExecuteScalarAsync()).ToString();
                    Console.WriteLine(name);
                }
            };

        }
        public static async void InsertStudent(string name, string surname)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Insert into OldStudents Values(@name,@surname)", conn))
                {
                    cmd.Parameters.AddWithValue("name", SqlDbType.NVarChar).Value = name;
                    cmd.Parameters.AddWithValue("surname", SqlDbType.NVarChar).Value = surname;
                    int result = await cmd.ExecuteNonQueryAsync();
                    if (result > 0)
                    {
                        Console.WriteLine("Ok");
                    }
                    else
                    {
                        Console.WriteLine("Not Ok");
                    }
                }
            };

        }
        public static async void GetAllStudents()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Select * from OldStudents", conn))
                {
                    SqlDataReader reader = await cmd.ExecuteReaderAsync();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //int id = reader.GetInt32(0);
                            //Console.WriteLine($"{reader[1]} {reader[2]}");
                            //Console.WriteLine($"{reader["Id"]} {reader["Name"]} {reader["Surname"]}");
                            Console.WriteLine($"{reader.GetInt32(0)} {reader.GetString(1)} {reader.GetString(2)}");
                        }
                    }
                }
            };

        }

        public static async void AddStudentWithEF(Student student)
        {
            using (AppDbContext db=new AppDbContext())
            {
                db.Students.Add(student);
                db.SaveChanges();
            }
            Console.WriteLine("OK");
        }

        public static async void GetAllStudentsWithEF()
        {
            using (AppDbContext db = new AppDbContext())
            {
               List<Student> students = db.Students.ToList();
                foreach (var item in students)
                {
                    Console.WriteLine($"{item.Name} {item.SurName} {item.Age}" );
                }
            }
         
        }

        public static async void GetStudentsWithEF(int id)
        {
            using (AppDbContext db = new AppDbContext())
            {
                Student item = db.Students.Find(id);
                
                    Console.WriteLine($"{item.Name} {item.SurName} {item.Age}");
                
            }

        }
    }
}