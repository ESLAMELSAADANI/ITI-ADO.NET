using Microsoft.Data.SqlClient;
using System.Data;

namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=.;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True";
            string commandString = "select * from student";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(commandString, conn);



            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            adapter.InsertCommand = commandBuilder.GetInsertCommand();
            adapter.UpdateCommand = commandBuilder.GetUpdateCommand();
            adapter.DeleteCommand = commandBuilder.GetDeleteCommand();

            adapter.Fill(dt);

            //View The Date Retrieved from Db Throw adapter and stored in App Memory throw dt Collection
            Console.WriteLine("========= Data Retrieved From DB Without Mapping ===============");
            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine($"{dr[0]} - {dr[1]} - {dr[2].ToString().Trim()} - {dr[3]} - {dr[4]} - {dr.RowState}");
            }
            Console.WriteLine();

            //Map the dr object as existing student object.
            List<Student> students = [];

            foreach (DataRow dr in dt.Rows)
            {
                int.TryParse(dr[0]?.ToString(), out int id);
                string? fname = dr[1]?.ToString();
                string? lname = dr[2]?.ToString()?.Trim();
                string? address = dr[3]?.ToString();
                int.TryParse(dr[4]?.ToString(), out int age);
                Student student = new Student()
                {
                    Id = id,
                    Fname = fname,
                    Lname = lname,
                    Address = address,
                    Age = age,
                };
                students.Add(student);
            }

            Console.WriteLine("========= Data Retrieved From DB After Mapping To Student object ===============");
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            #region 01 - Insert New Student(Added)

            //Console.WriteLine("======= After Add new Student =======");
            ////Insert new row in dt
            ////dt.Rows.Add(7850, "Nora", "Khalid", "Mansoura", 55);//Add in App Memory not in DB (Added)
            //foreach (DataRow dr in dt.Rows)
            //{
            //    Console.WriteLine($"{dr[0]} - {dr[1]} - {dr[2].ToString().Trim()} - {dr[3]} - {dr[4]} - {dr.RowState}");
            //}
            ////adapter.Update(dt);//To affect the DB. 

            #endregion

            #region 02 - Update Specific Student(Modified)

            //Console.WriteLine("======= After Update Specific =======");
            //dt.Rows[0][1] = "Eslam Elsaadany";
            //foreach (DataRow dr in dt.Rows)
            //{
            //    Console.WriteLine($"{dr[0]} - {dr[1]} - {dr[2].ToString().Trim()} - {dr[3]} - {dr[4]} - {dr.RowState}");
            //}
            //adapter.Update(dt);

            #endregion

            #region 03 - Delete Specific Course(Deleted)

            //commandString = "select * from course";

            //conn = new SqlConnection(connectionString);
            //cmd = new SqlCommand(commandString, conn);



            //dt = new DataTable();
            //adapter = new SqlDataAdapter(cmd);
            //commandBuilder = new SqlCommandBuilder(adapter);
            //adapter.InsertCommand = commandBuilder.GetInsertCommand();
            //adapter.UpdateCommand = commandBuilder.GetUpdateCommand();
            //adapter.DeleteCommand = commandBuilder.GetDeleteCommand();

            //adapter.Fill(dt);

            //dt.Rows[1].Delete();
            //Console.WriteLine(dt.Rows[1].RowState);
            //adapter.Update(dt);

            #endregion

        }
    }
}
