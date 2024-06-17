using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IQuestionRepository
    {
        public Task<Question?> GetQuestion(int questionId);
        public Question Save(Question question);
        public Task<List<Question>> GetAllQuestions();
        public void UpdateQuestion(Question question);
    }
}
