//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineBankingApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.AdminApprovals = new HashSet<AdminApproval>();
            this.Beneficiaries = new HashSet<Beneficiary>();
        }
    
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string FatherName { get; set; }
        public System.DateTime DOB { get; set; }
        public string PermanentAddress { get; set; }
        public string CurrentAddress { get; set; }
        public string OccupationType { get; set; }
        public string SourceOfIncome { get; set; }
        public int AnnualIncome { get; set; }
        public string DebitCardOpted { get; set; }
        public string NetBankingOpted { get; set; }
        public System.DateTime DateOfApplication { get; set; }
        public string Approved { get; set; }
        public string AccountNumber { get; set; }
        public int Balance { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdminApproval> AdminApprovals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Beneficiary> Beneficiaries { get; set; }
        public virtual NetBanking NetBanking { get; set; }
    }
}
