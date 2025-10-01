using Microsoft.Data.SqlClient;

namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //CRUD Operations

            #region 01 - Read

            ////Instantiate Connection with ITI Database and server ESLAM
            //SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");

            ////Write A Command That Will Executed On This DB
            //SqlCommand sqlCommand = new SqlCommand("select * from student", sqlConnection);

            ////Open The Connection With The DB ITI
            //sqlConnection?.Open();

            ////Read The Result Of Query Row By Row
            //SqlDataReader reader = sqlCommand.ExecuteReader();

            ////while (reader.Read())
            ////{
            ////    Console.WriteLine($"{reader[0]} - {reader[1]} - {reader[2]} - {reader[3]} - {reader[4]}");
            ////}

            ////Read The Result and insert it as values fo student object property
            //List<Student> students = [];
            //while (reader.Read())
            //{
            //    students.Add(new Student()
            //    {
            //        Id = reader.GetInt32(0),
            //        FName = reader.GetString(1),
            //        LName = reader.GetString(2),
            //        Address = reader.GetString(3),
            //        Age = reader.GetInt32(4)
            //    });
            //}

            //foreach (var item in students)
            //{
            //    Console.WriteLine(item);
            //}

            ////Close The Connection
            //sqlConnection?.Close(); 

            #endregion

            #region 02 - Create/Insert

            //SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");

            //SqlCommand command = new SqlCommand("insert into student(St_Id,St_Fname,St_Lname,St_Address,St_Age) values(1710,'Eslam','Elsaadany','Alriyad',23)");

            //command.Connection = connection;

            //connection?.Open();

            //int NofRowsAffects = command.ExecuteNonQuery();//Return N of rows affects after execute command on DB.
            //Console.WriteLine(NofRowsAffects);

            //connection?.Close(); 

            #endregion

            #region 03 - Update

            //SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");

            //SqlCommand command = new SqlCommand("update instructor set Salary = @Salary where Ins_Id = @Id", connection);

            //command.Parameters.AddWithValue("@salary", 6000);
            //command.Parameters.AddWithValue("@Id", 2);

            //connection?.Open();

            //int NofRowsAffected = command.ExecuteNonQuery();

            //Console.WriteLine($"{NofRowsAffected} row(s) updated."); 

            //connection?.Close();

            #endregion

            #region 04 - Delete

            //string connectionString = "Data Source=.;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True";
            ////connectionString = null;
            //string commandString = "delete from instructor where Ins_Id = @Id";

            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
            //    using (SqlCommand cmd = new SqlCommand(commandString, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@Id", 17);

            //        try
            //        {
            //            conn.Open();
            //            int rowsAffected = cmd.ExecuteNonQuery();
            //            Console.WriteLine($"{rowsAffected} row(s) deleted.");
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine("Error: " + ex.Message);
            //        }
            //    }
            //} 

            #endregion


        }
    }
}
