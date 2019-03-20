using System.ComponentModel.DataAnnotations;

namespace AuditDemo.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}