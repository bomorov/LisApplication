using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Enums
{
    public  enum HospitalType
    {
        /// <summary>Туберкулезный</summary>
        [Display(Name = "Туберкулезный")]
        Tuberculosis=1,

        /// <summary>Нетуберкулезный</summary>
        [Display(Name = "Нетуберкулезный")]
        Untuberculosis = 1
    }
}
