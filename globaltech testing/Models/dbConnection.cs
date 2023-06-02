
using globaltech_testing.ViewModel;
using System.Data.SqlClient;

namespace globaltech_testing.Models
{
    public class dbConnection
    {
        private SqlConnection con;
        private void connection()
        {
            string constring = "Data Source=RND-6;Initial Catalog=bikeshkumargupta;Integrated Security=True;Pooling=False";
            con = new SqlConnection(constring);
        }
        public bool create(User users)
        {
            connection();
            SqlCommand cmd = new SqlCommand("INSERT INTO users(name, email, password) VALUES('"+ users.Name +"','"+ users.Email +"','" + users.Password + "')",con);   
            con.Open();
            var i = cmd.ExecuteNonQuery(); 
            con.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
