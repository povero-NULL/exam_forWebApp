using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using exam.Models;

    public class QuestionsContext : DbContext
    {
        public QuestionsContext (DbContextOptions<QuestionsContext> options)
            : base(options)
        {
        }

        public DbSet<exam.Models.Question> Questions { get; set; } = default!;
    }
