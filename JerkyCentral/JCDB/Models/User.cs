namespace JCDB.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public bool ManagerStatus { get; set; }
    }
}