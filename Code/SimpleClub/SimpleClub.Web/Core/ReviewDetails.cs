using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleClub.Web {
    public class ReviewDetails {
        public string UserDetails { get; set; }
        public string[] UserRecal { get; set; }
        public string UserPhotoUrl { get; set; }
        public SiteSectonType SiteSection { get; set; }
    }
}