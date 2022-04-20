namespace JWT.Models
{
    public class UserWithTocken : Users
    {
        public string Token { get; set; }
        public string RefreshToken_ { get; set; }
        
        public UserWithTocken(Users user)
        {
            this.Id = user.Id;
            this.Email = user.Email;
            this.Login = user.Login;
            this.Roles = user.Roles;
        }
    }
}