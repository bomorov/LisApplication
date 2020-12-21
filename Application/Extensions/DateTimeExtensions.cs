using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Common.Extensions
{
    public static class DateTimeExtensions
    {
        public static string ToRuDateString(this DateTime dateTime)
        {
            return dateTime.ToString("dd MMMM yyyy", new System.Globalization.CultureInfo("ru-Ru"));
        }

        public static string ToRuShortDateString(this DateTime dateTime)
        {
            return dateTime.ToString("dd/MM/yyyy", new System.Globalization.CultureInfo("ru-Ru"));
        }
    }
}
