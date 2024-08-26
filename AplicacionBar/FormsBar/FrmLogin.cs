using System.Text.Json;
using System.Text;
using Microsoft.VisualBasic.ApplicationServices;
using Clases;
using System.Data.SqlClient;

namespace FormsBar
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            if (Validation())
            {
                FrmMesas frm = new FrmMesas();
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No funco la validacion del login");
            }

        }

        private bool Validation()
        {
             return ADO.Read(this.txtUser.Text, txtPassword.Text);

            /* Validacion con archivo
            using (StreamReader read = new StreamReader(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "P\\Proyectos\\Bar\\AplicacionBar\\usuarios.json"), Encoding.UTF8))
            {
                List<Clases.User> lista = JsonSerializer.Deserialize<List<Clases.User>>(read.ReadToEnd());
                bool flag = false;
                foreach (Clases.User user in lista)
                {
                    if (this.txtUser.Text == user.Name && this.txtPassword.Text == user.Password)
                    {
                        Bar.User = user;
                        flag = true;
                    }
                }
                return flag;
            }*/

        }

        //subir datos / crear archivo DE USUARIOS
        /* 
        private void crear()
        {
            
            SqlConnection con = new SqlConnection("Server=.;Database=Bar;Trusted_Connection=True;");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.usuarios (name,lastName,password,userType) VALUES(@name,@lastname,@pass,@usertype)");
            cmd.Connection = con;

            List <Clases.User> lista = new List<Clases.User>();
            lista.Add(new Clases.Employee(0, "Lucas", "Gonzales", "123", EShifts.first));
            lista.Add(new Clases.Employee(1, "Tomas", "Gomez", "321", EShifts.second));
            lista.Add(new Clases.Admin(2, "Admin", "1", "456"));
            lista.Add(new Clases.Owner(3, "owner", "owner", "123456"));
            
            foreach (Clases.User item in lista)
            {
                cmd.Parameters.AddWithValue("@name", item.Name);
                cmd.Parameters.AddWithValue("@lastname", item.LastName);
                cmd.Parameters.AddWithValue("@pass", item.Password);
                cmd.Parameters.AddWithValue("@usertype", item.UserType);

                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
            }

            con.Close();
            using (StreamWriter writer = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "usuarios.json")))
            {
                writer.WriteLine(JsonSerializer.Serialize(lista));
            }
        }
        */

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
