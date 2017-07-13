using System;

namespace StudentHelper.DAL.Contracts.Entities
{
    public partial class Script
    {
        public int ScriptId { get; set; }
        public int? ScienceId { get; set; }
        public int? LanguageId { get; set; }
        public int? UserId { get; set; }
        public DateTime DateCreated { get; set; }
        public string ScriptTitle { get; set; }

    }
}
