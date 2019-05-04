using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class ExamAnswerContext : DbContext
    {
        public ExamAnswerContext(DbContextOptions<ExamAnswerContext> options)
        : base(options)
        {
        }

        public DbSet<ExamEntity> Exams { get; set; }

        public DbSet<QuestionEntity> Questions { get; set; }

        public DbSet<AnswerEntity> Answers { get; set; }
    }
}
