using Domain.Entity;
using Domain.Repository;
using Infra;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository
{
    public class QuizRepository : BaseRepository<Quiz, int>, IQuizRepository
    {
        public QuizRepository(QuizDbContext db) : base(db)
        {
        }

        public Task DeleteQuizAsync(int quizId) => Delete(quizId);

        public Task<List<Quiz>> GetAllQuizAsync() => GetAll(new List<string> { "Questions" });

        public Task<Quiz?> GetFavoritesAsync(string user)
        {
            throw new NotImplementedException();
        }

        public Task<Quiz?> GetQuizAsync(int quizID) => Get(quizID, new List<string> { "Questions" });

        public Task<Quiz> SaveAsync(Quiz quiz) => Add(quiz);

        public Task UpdateQuizAsync(Quiz quiz) => Update(quiz);
    }
}
