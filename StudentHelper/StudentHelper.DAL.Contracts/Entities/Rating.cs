namespace StudentHelper.DAL.Contracts.Entities
{
=
    public partial class Rating
    {
        public int RatingId { get; set; }

        public int? UserId { get; set; }

        public int? ScriptId { get; set; }

        public int RatingValue { get; set; 
    }
}
