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
        public Task<List<Quiz>> GetQuizList();
        public List<Quiz> GetFavorites(string user);
        public Task<Quiz> GetQuiz(int id);
        public Quiz SaveQuiz(Quiz quiz);
        public void DeleteQuiz(int id);
        public void UpdateQuiz(Quiz quiz);
    }
}
