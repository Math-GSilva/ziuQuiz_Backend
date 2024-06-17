using Domain.Entity;
using Domain.Repository;
using Infra;

namespace Repository
{
    public class QuizRepository : BaseRepository<Quiz, int>, IQuizRepository
    {
        public QuizRepository() { }

        public QuizRepository(UsuarioDbContext db)
            : base(db)
        {
        }

        public void DeleteQuiz(int quizId) => base.Delete(quizId);

        public Task<List<Quiz>> GetAllQuiz() => base.GetAll();

        public Task<Quiz?> GetFavorites(string user)
        {
            throw new NotImplementedException();
        }

        public Task<Quiz?> GetQuiz(int quizID) => base.Get(quizID);

        public Quiz Save(Quiz quiz) => base.Add(quiz);

        public void UpdateQuiz(Quiz quiz) => base.Update(quiz);
    }
}
