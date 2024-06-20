using Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IQuizRepository
    {
        Task<Quiz?> GetQuizAsync(int quizID);
        Task<Quiz?> GetFavoritesAsync(string user);
        Task<Quiz> SaveAsync(Quiz quiz);
        Task<List<Quiz>> GetAllQuizAsync();
        Task UpdateQuizAsync(Quiz quiz);
        Task DeleteQuizAsync(int quizId);
    }
}
