using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Testlogin.Models;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter;

        public Service1()
        {
            ConnetDB();
        }

        void ConnetDB()
        {
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-SVGCNE3\SQLEXPRESS;Initial Catalog=TutorialDB;Integrated Security=True");
                com = con.CreateCommand();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int Registerid(RegisterViewModel r)
        {
            try
            {
                com.CommandText = "INSERT INTO Users(ID,PW,Name,Lastname,email,Age)VALUES(@user,@PW,@Name,@Lastname,@email,@Age)";
                com.Parameters.AddWithValue("user", r.ID);
                com.Parameters.AddWithValue("PW", r.PW);
                com.Parameters.AddWithValue("Name", r.Name);
                com.Parameters.AddWithValue("Lastname", r.Lastname);
                com.Parameters.AddWithValue("email", r.email);
                com.Parameters.AddWithValue("Age", r.Age);

                com.CommandType = CommandType.Text;
                con.Open();
                return com.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public int Updateid(RegisterViewModel r)
        {
            try
            {
                com.CommandText = "UPDATE Users SET PW=@PW ,Name=@Name , Lastname=@Lastname, email=@email , Age =@Age   WHERE ID =@user";
                com.Parameters.AddWithValue("user", r.ID);
                com.Parameters.AddWithValue("PW", r.PW);
                com.Parameters.AddWithValue("Name", r.Name);
                com.Parameters.AddWithValue("Lastname", r.Lastname);
                com.Parameters.AddWithValue("email", r.email);
                com.Parameters.AddWithValue("Age", r.Age);

                com.CommandType = CommandType.Text;
                con.Open();
                return com.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public int Repass(RepasswordViewModel re)
        {
            try
            {
                com.CommandText = "UPDATE Users Set PW=@PW WHERE ID=@user";
                com.Parameters.AddWithValue("user",re.username);
                com.Parameters.AddWithValue("PW",re.NewPassword);
                com.CommandType = CommandType.Text;
                con.Open();
                return com.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }

        }

        public int Deleteid(LoginViewModel l)
        {
            try
            {
                com.CommandText = "DELETE FROM Users WHERE ID=@user AND PW=@PW";
                com.Parameters.AddWithValue("user", l.Username);
                com.Parameters.AddWithValue("PW", l.Password);
                com.CommandType = CommandType.Text;
                con.Open();
                return com.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public List<RegisterViewModel> Getlogin(LoginViewModel l)
        {
            List<RegisterViewModel> datauser = new List<RegisterViewModel>();
            try
            {
                com.CommandText = "SELECT * FROM Users WHERE ID=@user AND PW=@PW";
                com.Parameters.AddWithValue("user", l.Username);
                com.Parameters.AddWithValue("PW", l.Password);
                com.CommandType = CommandType.Text;
                con.Open();
                dataReader = com.ExecuteReader();
                while (dataReader.Read())
                {
                    RegisterViewModel user = new RegisterViewModel()
                    {
                        ID = dataReader[0].ToString(),
                        PW = dataReader[1].ToString(),
                        Name = dataReader[2].ToString(),
                        Lastname = dataReader[3].ToString(),
                        email = dataReader[4].ToString(),
                        Age = Convert.ToInt32(dataReader[5])
                    };
                    datauser.Add(user);
                }
                return datauser;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public int? Checkid(RegisterViewModel r)
        {
            try
            {
                int? result = null ;
                com.CommandText = "SELECT * FROM Users WHERE ID=@user";
                com.Parameters.AddWithValue("user",r.ID);
                com.CommandType = CommandType.Text;
                con.Open();
                dataReader = com.ExecuteReader();
                if (dataReader.HasRows)
                {
                    result = 1;
                }
                return result;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public int? Checkemail(RegisterViewModel r)
        {
            try
            {
                int? result = null;
                com.CommandText = "SELECT * FROM Users WHERE email=@email";
                com.Parameters.AddWithValue("email",r.email);
                com.CommandType = CommandType.Text;
                con.Open();
                dataReader = com.ExecuteReader();
                if (dataReader.HasRows)
                {
                    result = 1;
                }
                return result;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }


    }
}
