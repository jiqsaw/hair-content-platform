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
    
    public partial class IGPhoto
    {
        public int Id { get; set; }
        public long IGUserId { get; set; }
        public long IGNomineeId { get; set; }
        public string CaptionText { get; set; }
        public int CommentCount { get; set; }
        public System.DateTime Created { get; set; }
        public string Filter { get; set; }
        public string Link { get; set; }
        public string LowResUrl { get; set; }
        public string StandardResUrl { get; set; }
        public string ThumbnailUrl { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreateDate { get; set; }
    }
}
