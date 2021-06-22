namespace FlourishFitness.Pages
{
    public interface IUser
    {
        User GetUser(string username, string password);
        void CreateUser();
        void UpdateUser();
        void DeleteUser();
        bool AuthenticateUser();

    }
}