//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JsonParseApp.Models.DpacDb
{
    using System;
    using System.Collections.Generic;
    
    public partial class fuserid
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fuserid()
        {
            this.customers = new HashSet<customer>();
            this.customers_financial = new HashSet<customers_financial>();
        }
    
        public string usr_id { get; set; }
        public string usr_passw { get; set; }
        public string officerid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string departid { get; set; }
        public string accs_code { get; set; }
        public Nullable<decimal> access { get; set; }
        public string approvalgroup { get; set; }
        public Nullable<bool> enabled { get; set; }
        public Nullable<bool> accountlockedout { get; set; }
        public Nullable<System.DateTime> act_startdate { get; set; }
        public Nullable<System.DateTime> act_enddate { get; set; }
        public Nullable<bool> logon_ind { get; set; }
        public Nullable<System.DateTime> logon_date { get; set; }
        public string logtime_in { get; set; }
        public string logtimeout { get; set; }
        public Nullable<System.DateTime> logout_in { get; set; }
        public string passw_5 { get; set; }
        public string passw_4 { get; set; }
        public string passw_3 { get; set; }
        public string passw_2 { get; set; }
        public string passw_1 { get; set; }
        public Nullable<System.DateTime> passw_exp { get; set; }
        public Nullable<decimal> maxapproval { get; set; }
        public Nullable<bool> unrestrict_acc { get; set; }
        public Nullable<bool> sunday_acc { get; set; }
        public Nullable<bool> monday_acc { get; set; }
        public Nullable<bool> tuesday_acc { get; set; }
        public Nullable<bool> wednesday_acc { get; set; }
        public Nullable<bool> thursday_acc { get; set; }
        public Nullable<bool> friday_acc { get; set; }
        public Nullable<bool> saturday_acc { get; set; }
        public Nullable<System.TimeSpan> sunday_s { get; set; }
        public Nullable<System.TimeSpan> sunday_e { get; set; }
        public Nullable<System.TimeSpan> monday_s { get; set; }
        public Nullable<System.TimeSpan> monday_e { get; set; }
        public Nullable<System.TimeSpan> tuesday_s { get; set; }
        public Nullable<System.TimeSpan> tuesday_e { get; set; }
        public Nullable<System.TimeSpan> wednesday_s { get; set; }
        public Nullable<System.TimeSpan> wednesday_e { get; set; }
        public Nullable<System.TimeSpan> thursday_s { get; set; }
        public Nullable<System.TimeSpan> thursday_e { get; set; }
        public Nullable<System.TimeSpan> friday_s { get; set; }
        public Nullable<System.TimeSpan> friday_e { get; set; }
        public Nullable<System.TimeSpan> saturday_s { get; set; }
        public Nullable<System.TimeSpan> saturday_e { get; set; }
        public Nullable<decimal> frerpseq { get; set; }
        public Nullable<bool> adminacc { get; set; }
        public string pos_code { get; set; }
        public string branch { get; set; }
        public Nullable<bool> active { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<customer> customers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<customers_financial> customers_financial { get; set; }
    }
}
