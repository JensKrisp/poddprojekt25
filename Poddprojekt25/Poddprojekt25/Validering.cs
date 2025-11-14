using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poddprojekt25
{
    internal class Validering
    {
        //Validering av URL, mer robust och läsbar än regex
        public static bool KontrolleraUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                return false;

            return Uri.TryCreate(url, UriKind.Absolute, out var uriResult)
                   && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

        //Validering av textfält, minst två tecken långa
        public static bool KontrolleraText(string? text)
        {
            return !string.IsNullOrWhiteSpace(text)
                   && text.Trim().Length >= 2;
        }



    }
}
