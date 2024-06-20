using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public interface IQuizService
    {
        public Task<List<Quiz>> GetQuizListAsync();
        public Task<List<Quiz>> GetFavoritesAsync(string user);
        public Task<Quiz> GetQuizAsync(int id);
        public Task<Quiz> SaveQuizAsync(Quiz quiz);
        public Task DeleteQuizAsync(int id);
        public Task UpdateQuizAsync(Quiz quiz);
    }
}
