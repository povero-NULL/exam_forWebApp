using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using exam.Models;

namespace exam.Pages.Questions
{
    public class IndexModel : PageModel
    {
        private readonly QuestionsContext _context;

        public IndexModel(QuestionsContext context)
        {
            _context = context;
        }

        public IList<Question> questions { get;set; } = default!;

        public async Task OnGetAsync()
        {
            questions = await _context.Questions.ToListAsync();
        }
    }
}
