namespace StudentHelper.DAL.Contracts.Entities
{
    public partial class Recension
    {
        public int RecensionId { get; set; }

        public int? ScriptId { get; set; }

        public int? UserId { get; set; }

        public string Text { get; set; }

        public DateTime RecensionDate { get; set; }

    }
}
