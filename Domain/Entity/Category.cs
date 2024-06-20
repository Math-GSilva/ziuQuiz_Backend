using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Domain.Repository;

namespace Domain.Entity
{
    public class Category : IEntity<int>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }
    }
}
