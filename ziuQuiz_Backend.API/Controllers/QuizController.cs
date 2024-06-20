using Domain.Entity;
using Domain.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace ziuQuiz_Backend.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuizController : ControllerBase
    {
        private readonly IQuizService _quizService;
        private readonly IConfiguration _configuration;

        public QuizController(IQuizService quizService, IConfiguration configuration)
        {
            _quizService = quizService ?? throw new ArgumentNullException(nameof(quizService));
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Quiz quiz)
        {
            if (quiz == null)
                return BadRequest("Quiz cannot be null");

            var savedQuiz = await _quizService.SaveQuizAsync(quiz);
            return Ok(savedQuiz);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetQuiz(int id)
        {
            if (id <= 0)
                return BadRequest("Invalid quiz ID");

            var quiz = await _quizService.GetQuizAsync(id);
            if (quiz == null)
                return NotFound("Quiz not found");

            return Ok(quiz);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuiz(int id)
        {
            if (id <= 0)
                return BadRequest("Invalid quiz ID");

            await _quizService.DeleteQuizAsync(id);
            return NoContent();
        }

        [HttpGet("list")]
        public async Task<IActionResult> GetQuizList()
        {
            var quizList = await _quizService.GetQuizListAsync();
            return Ok(quizList);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateQuiz([FromBody] Quiz quiz)
        {
            if (quiz == null)
                return BadRequest("Quiz cannot be null");

            await _quizService.UpdateQuizAsync(quiz);
            return NoContent();
        }

        [HttpGet("favorites/{user}")]
        public async Task<IActionResult> GetFavorites(string user)
        {
            if (string.IsNullOrWhiteSpace(user))
                return BadRequest("User cannot be null or empty");

            var favoriteQuizzes = await _quizService.GetFavoritesAsync(user);
            return Ok(favoriteQuizzes);
        }
    }
}
