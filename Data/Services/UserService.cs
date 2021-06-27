namespace FlourishFitness.Pages
{
    public class UserService : IUser
    {
        public bool AuthenticateUser()
        {
            return true;
        }

        public void CreateUser()
        {
            throw new System.NotImplementedException();
        }

        public void DeleteUser()
        {
            throw new System.NotImplementedException();
        }

        public User GetUser(string username, string password)
        {
            if (AuthenticateUser()) {
                return new User{ Id=1, Username=username, Password=password, Email="example@fake.com" }
            }
            throw new System.NotImplementedException();
        }

        public void UpdateUser()
        {
            throw new System.NotImplementedException();
        }
    }
}