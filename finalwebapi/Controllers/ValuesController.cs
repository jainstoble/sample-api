using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;
using project;
//using static finalwebapi.GeneralConnection;
namespace finalwebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
      //  private string connStringWithoutPass;

        [HttpGet("Register")]
        public int Register(int Id, string Name, string Password, string Address)
        {
          //  string datasource = @"KCT-L-441\SQLEXPRESS";
          //  string database = "User_jain";
          //  string username = "sa";
          //   string password = "password";
          //  //    //string id1 = string.Empty;
          //string connStringPass = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
          //  string connStringWithoutPass = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;Integrated Security=SSPI";
            string Query = "INSERT INTO [User]values('" + Name + "','" + Id + "','" + Address + "','" + Password + "')";
            //GeneralConnection generalConnection = new GeneralConnection();
            string connectionString = GeneralConnection.connStringWithoutPass();
            SqlConnection conn = new SqlConnection(connectionString);
          //  string Query = "INSERT INTO User VALUES(@Id,@Name, @Password, @Address)";
            SqlCommand cmd = new SqlCommand(Query, conn);
              conn.Open();
             cmd.ExecuteNonQuery();
            conn.Close();
            
            
            
            
            //Generalconnection(Query);
            //   string Query = "Select * from [User]";
            //SqlCommand cmd = new SqlCommand(Query, conn);

            // conn.Open();


            // cmd.ExecuteNonQuery();
            //SqlDataReader reader = cmd.ExecuteReader();
            //if (reader.HasRows)
            //{
            //    while (reader.Read())
            //    {
            //        id1 = reader["Id"].ToString();
            //    }
            //}
            //reader.Close();


            //    User user1 = new User();
            //   user1.Id = id;
            //   user1.Name = Name;
            //  user1.Password = Password;
            // user1.Address = Address;
            // a.Add(user1);
           
            return 1;


        }



       

        [HttpGet("Valid")]

        
        public bool Valid(int id)
        {

            //string datasource = @"KCT-L-441\SQLEXPRESS";
            //string database = "User_jain";
            //string username = "sa";
            //string password = "password";
            string id1 = string.Empty;
            //string connStringPass = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            //string connStringWithoutPass = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;Integrated Security=SSPI";
            // string Query = "INSERT INTO [User]values('" + Name + "','" + Id + "','" + Address + "','" + Password + "')";
            string connectionString = GeneralConnection.connStringWithoutPass();
            SqlConnection conn = new SqlConnection(connectionString);



            string Query = "Select * from [User] where Id= 'id'";
            //SqlConnection conn = new SqlConnection(connStringWithoutPass);
           
            SqlCommand cmd = new SqlCommand(Query, conn);
            conn.Open();
            // cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                //    reader.Close();
                //    conn.Close();
                //    return true;
                //}
                while (reader.Read())
                {
                    id1 = reader["Id"].ToString();
                    /// id1 = reader["Id"];
                    string id2 = id.ToString();
                    if (id1 == id2)
                    {
                        reader.Close();
                        conn.Close();
                        return true;

                    }



                }

                //  string Query= "SELECT * FROM [Users] where Name ="' + Name + '" AND Id ="' + id + '"';

                //List<int> a = new List<int>();
                // a.Add(id);
                //  foreach (User i in a)
                // {
                //    if (i.Id == id)
                //       return true;

                // }
                reader.Close();
                conn.Close();

                

            }
            return false;
        }

        [HttpPut("Update")]
        public bool Update(int id ,string Name, string Password, string Passwordn)
        {



            //foreach (User i in a)
            //{
            //    if (i.Name == Name && i.Password == Password)
            //    {
            //        i.Password = Passwordn;
            //        return true;
            //    }

            //}


            string datasource = @"KCT-L-441\SQLEXPRESS";
            string database = "User_jain";
            string username = "sa";
            string password = "password";
            string id1 = string.Empty;
            string connStringPass = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            string connStringWithoutPass = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;Integrated Security=SSPI";
            // string Query = "INSERT INTO [User]values('" + Name + "','" + Id + "','" + Address + "','" + Password + "')";
            // string Query = "Select * from [User] where Id= 'id'";
            // string Query = "UPDATE [User] SET Password='Passwordn' where Name='Name'";

            //string Query = "Update [User] set  Password = '" + Passwordn + "' where Name = '" + Name + "' and Password = '" + Password +"' ";
            string Query = "Update [User] set Password = '" + Passwordn + "' where name='" + Name + "' and Password = '" + Password + "'";

            SqlConnection conn = new SqlConnection(connStringWithoutPass);
            SqlCommand cmd = new SqlCommand(Query, conn);
            conn.Open();
             cmd.ExecuteNonQuery();
           // SqlDataReader reader = cmd.ExecuteReader();
            //if (reader.HasRows)

            //    while (reader.Read())
            //    {
            //        id1 =reader["Id"].ToString();
                    

            //    }
            //}
        //    reader.Close();
            conn.Close();
            return true;


        }
        [HttpGet("login")]
        public bool login(string Name, string Password)
        {
            //foreach (User i in a)
            //{
            //    if (i.Name == Name && i.Password == Password)
            //    {
            //        return true;
            //    }

            //}
            string datasource = @"KCT-L-441\SQLEXPRESS";
            string database = "User_jain";
            string username = "sa";
            string password = "password";
            string id1 = string.Empty;
            string connStringPass = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            string connStringWithoutPass = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;Integrated Security=SSPI";
            // string Query = "INSERT INTO [User]values('" + Name + "','" + Id + "','" + Address + "','" + Password + "')";
            string Query = "Select * from [User] where Name= '"+Name+ "' and Password= '"+Password+ "' ";
            SqlConnection conn = new SqlConnection(connStringWithoutPass);
            SqlCommand cmd = new SqlCommand(Query, conn);
            conn.Open();
            // cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                //    reader.Close();
                //    conn.Close();
                //    return true;
                //}
                while (reader.Read())
                {
                   string Name1 = reader["Name"].ToString().Trim();
                    string password1 = reader["Password"].ToString().Trim();
                    /// id1 = reader["Id"];
                   // string id2 = id.ToString();
                    if (Name == Name1&&Password==password1)
                    {
                        reader.Close();
                        conn.Close();
                        return true;

                    }
                   



                }

                //  string Query= "SELECT * FROM [Users] where Name ="' + Name + '" AND Id ="' + id + '"';

                //List<int> a = new List<int>();
                // a.Add(id);
                //  foreach (User i in a)
                // {
                //    if (i.Id == id)
                //       return true;

                // }
                reader.Close();
                conn.Close();



            }
           




            return false;


        }

        //public static void Generalconnection(string Query1)
        //{
        //    string datasource = @"KCT-L-441\SQLEXPRESS";
        //    string database = "User_jain";
        //    string username = "sa";
        //    string password = "password";
        //    //string id1 = string.Empty;
        //    string connStringPass = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
        //    string connStringWithoutPass = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;Integrated Security=SSPI";

        //    SqlConnection conn = new SqlConnection(connStringWithoutPass);
        //    SqlCommand cmd = new SqlCommand(Query1, conn);
        //    conn.Open();
        //    cmd.ExecuteNonQuery();
        //    conn.Close();


        //}


        //[HttpGet("Otp")]


        //public char[] Otp(int mobileno)
        //{
        //    string otp = String.Empty;

        //    //string tempChars = String.Empty;

        //    string _allowedChars = "#@$&*abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789#@$&*";
        //    //Random rand = new Random();
        //    int n = _allowedChars.Length;
        //    char[] chars = new char[6];
        //    for (int i = 0; i < 6; i++)

        //    {

        //        chars[i] = _allowedChars[(int)_allowedChars[i]%n];

               
        //    }

        //    return chars;


           
        //}




    }
}
