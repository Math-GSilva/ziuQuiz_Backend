using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Domain.Repository;

namespace Domain.Entity
{
    [Table("Questao")]
    public class Question : IEntity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Description { get; set; }
        public string Answer { get; set; }
        public int QuizId { get; set; }
    }
}
