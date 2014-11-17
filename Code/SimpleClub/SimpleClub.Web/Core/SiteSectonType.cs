using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SimpleClub.Web {
    public enum SiteSectonType {
        [Description("Клуб")]
        Club,
        [Description("Skype")]
        SkypeLessons,
        [Description("Взрослые")]
        IndividualLessons,
        [Description("Школьники")]
        IndividualLessonsForChildren
    }
}