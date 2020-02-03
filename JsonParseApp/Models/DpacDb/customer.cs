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
    
    public partial class customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public customer()
        {
            this.fxrefbors = new HashSet<fxrefbor>();
            this.individual_financials = new HashSet<individual_financials>();
            this.loans = new HashSet<loan>();
        }
    
        public string ctype { get; set; }
        public string officerid { get; set; }
        public string fbonumbr { get; set; }
        public string fbobname { get; set; }
        public string prefix { get; set; }
        public Nullable<System.DateTime> appldate { get; set; }
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public string aliasname { get; set; }
        public Nullable<decimal> marriedstatus { get; set; }
        public string next_kin { get; set; }
        public string relationshipkin { get; set; }
        public Nullable<decimal> sex { get; set; }
        public string spousename { get; set; }
        public Nullable<decimal> fbos1bal { get; set; }
        public Nullable<System.DateTime> fbos1lad { get; set; }
        public Nullable<decimal> fbos2bal { get; set; }
        public Nullable<System.DateTime> fbos2lad { get; set; }
        public Nullable<decimal> fbos3bal { get; set; }
        public Nullable<System.DateTime> fbos3lad { get; set; }
        public string fbomodid { get; set; }
        public Nullable<System.DateTime> fbomoddt { get; set; }
        public string fbobadr1 { get; set; }
        public string fbobadr2 { get; set; }
        public string home_status { get; set; }
        public string town { get; set; }
        public string district { get; set; }
        public string country { get; set; }
        public string addresstownbusiness { get; set; }
        public string addressdistrictbusiness { get; set; }
        public string addresscountrybusiness { get; set; }
        public string addressbusiness2town { get; set; }
        public string addressbusiness2district { get; set; }
        public string addressbusiness2country { get; set; }
        public string businessplace { get; set; }
        public string besinessplace2 { get; set; }
        public Nullable<System.DateTime> employfrom2 { get; set; }
        public Nullable<System.DateTime> employfrom { get; set; }
        public Nullable<System.DateTime> employto2 { get; set; }
        public Nullable<System.DateTime> employto { get; set; }
        public Nullable<decimal> yearsaddr { get; set; }
        public string nationality { get; set; }
        public string previousworkphone { get; set; }
        public string workphone2 { get; set; }
        public string workphone { get; set; }
        public string fax { get; set; }
        public Nullable<decimal> empstatus { get; set; }
        public string homephone { get; set; }
        public string otherphone { get; set; }
        public string mobilphone { get; set; }
        public string otheremail { get; set; }
        public string emailname { get; set; }
        public Nullable<System.DateTime> birthdate { get; set; }
        public string typeofid { get; set; }
        public string healthstatus { get; set; }
        public string pastemployer { get; set; }
        public Nullable<System.DateTime> pastempfrom { get; set; }
        public Nullable<System.DateTime> pastempto { get; set; }
        public string note { get; set; }
        public Nullable<decimal> depends { get; set; }
        public string secondoccupation { get; set; }
        public string occupation { get; set; }
        public string secondoccupgrp { get; set; }
        public string occupgrp { get; set; }
        public string secondoccup { get; set; }
        public string mainoccup { get; set; }
        public string indusgrp { get; set; }
        public string mainindus { get; set; }
        public string fbobkind { get; set; }
        public byte[] cphoto { get; set; }
        public Nullable<decimal> numemploy { get; set; }
        public Nullable<System.DateTime> datestart { get; set; }
        public string busdescrip { get; set; }
        public string bus_resp { get; set; }
        public string bus_posit { get; set; }
        public string bus_type { get; set; }
        public Nullable<System.DateTime> date_lact { get; set; }
        public string user_lact { get; set; }
        public Nullable<decimal> secondoccupationobtion { get; set; }
        public Nullable<bool> isdeleted { get; set; }
        public Nullable<int> years_emp { get; set; }
        public string address1business { get; set; }
        public string address2business { get; set; }
        public string address2business2 { get; set; }
        public string address1business2 { get; set; }
        public Nullable<decimal> num_inhouse { get; set; }
        public string company_name { get; set; }
        public string mailing_address1 { get; set; }
        public string mailing_address2 { get; set; }
        public string mailingtown { get; set; }
        public string mailingdistrict { get; set; }
        public string mailingcountry { get; set; }
        public string sec_idtype { get; set; }
        public string sec_idnumber { get; set; }
        public Nullable<decimal> sex_bus_resp { get; set; }
        public string prefix_bus_resp { get; set; }
        public string idnumber { get; set; }
        public string othname { get; set; }
        public Nullable<bool> fladelet { get; set; }
        public string prevcustno { get; set; }
        public string flauser1_cu { get; set; }
        public string flauser2_cu { get; set; }
        public string flauser3_cu { get; set; }
        public string flauser4_cu { get; set; }
        public string flauser5_cu { get; set; }
        public string flauser6_cu { get; set; }
        public Nullable<System.DateTime> flauser1date_cu { get; set; }
        public Nullable<System.DateTime> flauser2date_cu { get; set; }
        public Nullable<System.DateTime> flauser3date_cu { get; set; }
        public Nullable<System.DateTime> flauser4date_cu { get; set; }
        public Nullable<System.DateTime> flauser5date_cu { get; set; }
        public Nullable<System.DateTime> flauser6date_cu { get; set; }
        public string companydirections { get; set; }
        public string homedirections { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fxrefbor> fxrefbors { get; set; }
        public virtual customers_financial customers_financial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<individual_financials> individual_financials { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<loan> loans { get; set; }
    }
}