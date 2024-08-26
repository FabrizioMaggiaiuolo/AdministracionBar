using System.Text.Json.Serialization;

namespace Clases
{
    public class User
    {
        private int id;
        private string name;
        private string lastName;
        private string password;
        private EUser userType;


        [JsonConstructor]
        public User(int id, string name, string lastName, string password, EUser userType)
        {
            this.id = id;
            this.name = name;
            this.lastName = lastName;
            this.password = password;
            this.userType = userType;
        }

        public int Id
        { get { return this.id; } set { this.id = value; } }

        public virtual string Password
        { get { return this.password; } set { this.password = value; } }

        public virtual string Name
        { get { return this.name; } set { this.name = value; } }

        public virtual string LastName
        { get { return this.lastName; } set { this.lastName = value; } }

        public virtual EUser UserType
        {  get { return this.userType; } set { this.userType = value; } }

        public static EUser ConvertToEUser(int num)
        {
            EUser retorno;
            switch(num)
            {
                case 0:
                    retorno = EUser.employee;
                    break;
                case 1:
                    retorno = EUser.admin;
                    break;
                case 2:
                    retorno = EUser.owner;
                    break;
                default:
                    retorno = EUser.dontExist;
                    break;
            }
            return retorno;
        }
    }
}
