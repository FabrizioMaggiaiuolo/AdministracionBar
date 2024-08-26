using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Numerics;

namespace Clases
{
    public static class ADO
    {
        private static SqlConnection conn = new SqlConnection("Server=.;Database=Bar;Trusted_Connection=True;");

        public static bool Create(User item)
        {
            bool retorno = true;
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.usuarios (name,lastName,password,userType) VALUES(@name,@lastname,@pass,@usertype)");
                cmd.Connection = conn;

                cmd.Parameters.AddWithValue("@name", item.Name);
                cmd.Parameters.AddWithValue("@lastname", item.LastName);
                cmd.Parameters.AddWithValue("@pass", item.Password);
                cmd.Parameters.AddWithValue("@usertype", item.UserType);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                retorno = false;
            }
            finally
            {
                conn.Close();
            }

            return retorno;

        }

        public static bool Update(User item)
        {
            bool retorno = true;
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE dbo.usuarios SET name = @name, lastName = @lastName, password = @pass, userType = @usertype WHERE id = @id");
                cmd.Connection = conn;

                cmd.Parameters.AddWithValue("@id", item.Id);
                cmd.Parameters.AddWithValue("@name", item.Name);
                cmd.Parameters.AddWithValue("@lastname", item.LastName);
                cmd.Parameters.AddWithValue("@pass", item.Password);
                cmd.Parameters.AddWithValue("@usertype", item.UserType);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                retorno = false;
            }
            finally
            {
                conn.Close();
            }

            return retorno;
        }

        public static bool Delete(User item) 
        {
            bool retorno = true;
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM dbo.usuarios WHERE id = @id");
                cmd.Connection = conn;

                cmd.Parameters.AddWithValue("@id", item.Id);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                retorno = false;
            }
            finally
            {
                conn.Close();
            }

            return retorno;
        }

        public static List<User> Read()
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.usuarios");
                cmd.Connection = conn;

                cmd.ExecuteNonQuery();
                List<User> respuesta = new List<User>();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        User usuario = new User(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            User.ConvertToEUser(reader.GetInt32(4))
                            );
                        respuesta.Add(usuario);
                    }
                }
                return respuesta;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static bool Read(User item)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.usuarios WHERE id = @id");
                cmd.Connection = conn;

                cmd.Parameters.AddWithValue("@id", item.Id);

                cmd.ExecuteNonQuery();
                List<User> lista = new List<User>();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public static bool Read(string name, string pass)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.usuarios WHERE name = @name AND password = @pass");
                cmd.Connection = conn;

                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Parameters.AddWithValue("@name", name);

                cmd.ExecuteNonQuery();
                List<User> lista = new List<User>();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public static void CreateMonth()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection("Server=.;Database=Prueba;Trusted_Connection=True;");
                SqlCommand sqlCommand;
                
                sqlConnection.Open();


                sqlCommand = new SqlCommand("INSERT INTO dbo.datosMensuales(mes, plata) VALUES (@mes, @plata)");

                sqlCommand.Connection = sqlConnection;

                sqlCommand.Parameters.AddWithValue("@mes", DateTime.Now.ToString("MMMM").Remove(0, 1).Insert(0, DateTime.Now.ToString("MMMM").ElementAt(0).ToString().ToUpper()));
                sqlCommand.Parameters.AddWithValue("@plata", Bar.Money);


                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
