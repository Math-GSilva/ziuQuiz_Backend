using Domain.Entity;
using Domain.Repository;
using Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class QuizService : IQuizService
    {
        IQuizRepository quizRepository;
        public QuizService(IQuizRepository quizRepository)
        {
            this.quizRepository = quizRepository;
        }

        public void DeleteQuiz(int id) => quizRepository.DeleteQuiz(id);

        public List<Quiz> GetFavorites(string user)
        {
            throw new NotImplementedException();
        }

        public Task<Quiz> GetQuiz(int id) => quizRepository.GetQuiz(id);

        public Task<List<Quiz>> GetQuizList() => quizRepository.GetAllQuiz();
        public Quiz SaveQuiz(Quiz quiz) => quizRepository.Save(quiz);

        public void UpdateQuiz(Quiz quiz) => quizRepository.UpdateQuiz(quiz);
    }
}
