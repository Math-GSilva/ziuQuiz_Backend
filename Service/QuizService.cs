using Domain.Entity;
using Domain.Repository;
using Domain.Service;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service
{
    public class QuizService : IQuizService
    {
        private readonly IQuizRepository _quizRepository;

        public QuizService(IQuizRepository quizRepository)
        {
            _quizRepository = quizRepository ?? throw new ArgumentNullException(nameof(quizRepository));
        }

        public async Task DeleteQuizAsync(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid quiz ID", nameof(id));

            await _quizRepository.DeleteQuizAsync(id);
        }

        public async Task<List<Quiz>> GetFavoritesAsync(string user)
        {
            if (string.IsNullOrWhiteSpace(user))
                throw new ArgumentException("User cannot be null or empty", nameof(user));

            // Aqui você pode implementar a lógica para obter os quizzes favoritos do usuário.
            // Vou lançar uma exceção genérica por enquanto.
            throw new NotImplementedException("This method is not yet implemented.");
        }

        public async Task<Quiz> GetQuizAsync(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid quiz ID", nameof(id));

            return await _quizRepository.GetQuizAsync(id);
        }

        public async Task<List<Quiz>> GetQuizListAsync() => await _quizRepository.GetAllQuizAsync();

        public async Task<Quiz> SaveQuizAsync(Quiz quiz)
        {
            if (quiz == null)
                throw new ArgumentNullException(nameof(quiz));

            return await _quizRepository.SaveAsync(quiz);
        }

        public async Task UpdateQuizAsync(Quiz quiz)
        {
            if (quiz == null)
                throw new ArgumentNullException(nameof(quiz));

            await _quizRepository.UpdateQuizAsync(quiz);
        }
    }
}
