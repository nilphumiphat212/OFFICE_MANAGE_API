using System;

namespace office_manage_api.Models.EF
{
    public record Tasklist
    {
        public int ID { get; set; }
        public string TaskName { get; set; }
        public string CreateBy { get; set; }
        public string TaskStatus { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime CompleteDate { get; set; }
        public string Remark { get; set; }
        public string ValidateBy { get; set; }
    }
}