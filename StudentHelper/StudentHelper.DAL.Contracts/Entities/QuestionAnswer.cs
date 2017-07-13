namespace StudentHelper.DAL.Contracts.Entities
{
    public  class QuestionAnswer
    {
        public int QuestionId { get; set; }

        public int? ScriptId { get; set; }

        public int? TestId { get; set; }

        public string Question { get; set; }
        
        public string Answer { get; set; }

        public bool? IsCorrect { get; set; }
    }
}
