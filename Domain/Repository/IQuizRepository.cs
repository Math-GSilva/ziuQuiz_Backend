using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IQuizRepository
    {
        public Task<Quiz?> GetQuiz(int quizID);
        public Task<Quiz?> GetFavorites(string user);
        public Quiz Save(Quiz quiz);
        public Task<List<Quiz>> GetAllQuiz();
        public void UpdateQuiz(Quiz quiz);
        public void DeleteQuiz(int quizId);
    }
}
