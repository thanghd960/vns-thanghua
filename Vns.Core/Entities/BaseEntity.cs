using System;
namespace Vns.Core.Entities
{
    public class BaseEntity 
    {
        public int Id { get; set; }
        public int Index { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ApprovedDate { get; set; }
        public string ApprovedBy { get; set; }
        public bool Status { get; set; }

        public BaseEntity()
        {
            Status = true;
            CreatedDate = DateTime.Now;
            CreatedBy = "admin";
        }

        public void ApproveEntity()
        {
            ApprovedBy = "admin";
            ApprovedDate = DateTime.Now;
        }

        public void Inactive()
        {
            Status = false;
            ApprovedBy = "admin";
            ApprovedDate = DateTime.Now;
        }
        
    }

}
