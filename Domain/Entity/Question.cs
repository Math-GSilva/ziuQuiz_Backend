using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    public class Question
    {
        public int Id { get; set; }

        public int IdQuiz { get; set; }

        [Required]
        public string Resposta { get; set; }

        [Required]
        public string Alternativa1 { get; set; }

        [Required]
        public string Alternativa2 { get; set; }

        [Required]
        public string Alternativa3 { get; set; }
    }
}
