using AgeArticle.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgeArticle.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly SurveyContext _context;

        [BindProperty]
        public int Age { get; set; }

        [BindProperty]
        public string Agree { get; set; }

        [BindProperty]
        public string Comment { get; set; }

        public bool IsSuccess { get; set; } = false;

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var surveyResponse = new SurveyResponse
                {
                    Age = Age,
                    Agree = Agree,
                    Comment = Comment
                };

                _context.surveyResponses.Add(surveyResponse);
                await _context.SaveChangesAsync();

                IsSuccess = true;
                return Page();
            }

            return Page();
        }

        public IndexModel(ILogger<IndexModel> logger, SurveyContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            Comment = "Sem comentário";
        }
    }
}
