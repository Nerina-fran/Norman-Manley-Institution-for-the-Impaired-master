
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Norman_Manley_Institution_for_the_Impaired
{

using System;
    using System.Collections.Generic;
    
public partial class DataforStudent
{

    public int id { get; set; }

    public string Nationality { get; set; }

    public Nullable<System.DateTime> DateofBirth { get; set; }

    public Nullable<int> Disabilityid { get; set; }

    public Nullable<int> StudentGenderid { get; set; }

    public Nullable<int> Classid { get; set; }

    public string ParentFirstName { get; set; }

    public string ParentLastName { get; set; }

    public string ContactNumber { get; set; }

    public string Address { get; set; }

    public string EmailAddress { get; set; }

    public string Status { get; set; }

    public string StudentFName { get; set; }

    public string StudentLName { get; set; }



    public virtual ClassDetail ClassDetail { get; set; }

    public virtual DisabilityList DisabilityList { get; set; }

    public virtual StudentGender StudentGender { get; set; }

}

}
