//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HairCare.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class IGCombinedPhoto
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public string StandardResUrl { get; set; }
        public string ThumbnailUrl { get; set; }
        public string CaptionText { get; set; }
        public string SharerName { get; set; }
        public string SharerProfilePic { get; set; }
        public string NomineeName { get; set; }
        public string NomineeProfilePic { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreateDate { get; set; }
    }
}