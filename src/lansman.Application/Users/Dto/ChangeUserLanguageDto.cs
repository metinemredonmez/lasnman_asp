using System.ComponentModel.DataAnnotations;

namespace lansman.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}