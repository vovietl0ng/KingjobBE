using System;

namespace Data.Entities
{
    public class CompanyBranch
    {

        public string Address { get; set; }
        public Guid CompanyId { get; set; }
        public CompanyInformation CompanyInformation { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
    }
}
