using Microsoft.VisualBasic;

namespace DPJI.API.Models
{
    public class TblUsers
    {
        public int Id { get; set; }
        public string Usertype { get; set; } = string.Empty;
        public string EmpID { get; set; }
        public string Firstname { get; set; } = string.Empty;
        public string Middlename { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string CreatedOn { get; set; } = string.Empty;
        public string UpdatedOn { get; set; } = string.Empty;
        public string BranchAssign { get; set; } = string.Empty;
        public string BranchActive { get; set; } = string.Empty;
        public int Active { get; set; }
        public int Enable { get; set; }
        public int Shw { get; set; }
    }
}
