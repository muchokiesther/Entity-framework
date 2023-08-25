namespace UserDomain
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }

        public List<Order> Orders { get; set; }
        public Cart Cart { get; set; }
    }

}