using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Domain.Repository;

namespace Domain.Entity
{
    public class Quiz : IEntity<int>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }
        public string Descricao { get; set; }
        public int TimesPlayed{ get; set; }
        public int RankedPlayers{ get; set; }
        public int Favourites{ get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
