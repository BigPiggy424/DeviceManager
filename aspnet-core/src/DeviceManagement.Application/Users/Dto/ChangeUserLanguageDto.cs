using System.ComponentModel.DataAnnotations;

namespace DeviceManagement.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}