using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Domain.Repository;

namespace Domain.Entity
{
    [Table("Quiz")]
    public class Quiz : IEntity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }
        public string Descricao { get; set; }
        public int TimesPlayed{ get; set; }
        public int RankedPlayers{ get; set; }
        public int Favourites{ get; set; }
        public Category Category { get; set; }
        public List<string> Tags{ get; set; }
        public List<Question> Questions { get; set; }
    }
}
