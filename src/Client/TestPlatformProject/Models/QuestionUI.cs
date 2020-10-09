using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.ModelsUI
{
    public class QuestionUI
    {
        public QuestionUI()
        {
            Answers = new List<AnswerUI>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Text { get; set; }
        public string ImageURL { get; set; }
        public bool IsManyAnswers { get; set; }
        public int Weight { get; set; }
        public int TestId { get; set; }
        public TestUI Test { get; set; }
        public IEnumerable<AnswerUI> Answers { get; set; }
    }
}
