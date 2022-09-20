using Microsoft.AspNetCore.Mvc;
using project;
//namespace project.models.User;
using System.Data.SqlClient;
namespace finalwebapi.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class HomeController : Controller
    {
        //  public static List<User> a = new List<User public static List<User> a = new List<User>();
       // public static List<User> A = null;
       // public static List<User> a { get { if (A == null) { A = new List<User>(); } return A; } set { } }
        //  private static List<User> a = null;
        //  public static List<User> A
        //  {
        //     get
        //     {
        //       if (a == null)
        //      {
        //   a = new List<User>();
        //      }
        //  return a;
        //   }

        //     set { }
        //   }
        [HttpGet("Register")]
        public int Register(int id, string Name, string Password, string Address)
        {
            string datasource = @"KCT-L-441\SQLEXPRESS";
            string database = "User_jain";
            string username = "sa";
            string password = "password";
            string id1=string.Empty;
            string connStringPass = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            string connStringWithoutPass = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;Integrated Security=SSPI";

            SqlConnection conn = new SqlConnection(connStringWithoutPass);
            string Query = "Select * from [User]";
            SqlCommand cmd = new SqlCommand(Query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                     id1= reader["Id"].ToString();
                }
            }
            reader.Close();
            conn.Close();

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
            //List<int> a = new List<int>();
            // a.Add(id);
          //  foreach (User i in a)
           // {
            //    if (i.Id == id)
             //       return true;

           // }

            return false;

        }
        [HttpPut("Update")]
        public bool Update(string Name, string Password, string Passwordn)
        {
            //foreach (User i in a)
            //{
            //    if (i.Name == Name && i.Password == Password)
            //    {
            //        i.Password = Passwordn;
            //        return true;
            //    }

            //}
            return false;


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
            return false;


        }




    }
}

