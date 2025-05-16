using System.ComponentModel.DataAnnotations;

namespace TestBlazorApp1.Models
{
    public class ServerDetails
    {
        public ServerDetails()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 2);
            IsOnline = randomNumber == 0 ? false : true;
        }

        public int ServerId { set; get; }
        public bool IsOnline { set; get; }
        [Required]
        public string? Name { set; get; }
        [Required]
        public string City { set; get; }
    }
}
