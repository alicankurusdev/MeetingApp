using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{

    public class UserInfo
    {

        public int Id { get; set; }
        [Required(ErrorMessage ="Name space is required")]
        public string? Name { get; set; }
        [Required(ErrorMessage ="Phone space is required")]
        public string? Phone { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="EmailAddress space is required")]
        public string? Email { get; set; }
        [Required(ErrorMessage ="Participation space is required")]
        public bool? Participation { get; set; }
    }


}