using Microsoft.Build.Framework;

namespace WebSite.Models
{
    public class Mail
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string SurName { get; set; }
        [Required]
        
        public string Email { get; set; }
        [Required]
        public string Topics { get; set; }
        [Required]
        public string Message { get; set; }

    }
}
