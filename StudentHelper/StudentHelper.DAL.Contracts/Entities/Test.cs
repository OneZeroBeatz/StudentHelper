namespace StudentHelper.DAL.Contracts.Entities
{
    public partial class Test
    {
        public int TestId { get; set; }

        public int? UserId { get; set; }

        public int? ScriptId { get; set; }

        public int? SumUncorrect { get; set; }

        public int? SumCorrect { get; set; }

        public DateTime DateOfTest { get; set; }

        public int? TestLength { get; set; }
    }
}
