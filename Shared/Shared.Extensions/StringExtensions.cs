using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.ComponentModel;

namespace Shared.Extensions.String
{
    public static class StringExtensions
    {
        public static string RemoveMask(this string value, bool onlyNumbers = true)
        {
            
            if (string.IsNullOrWhiteSpace(value))
                return value;

            if (onlyNumbers)
                return new string(value.Where(c => char.IsNumber(c)).ToArray());

            return new string(value.Where(c => char.IsLetter(c) || char.IsNumber(c)).ToArray());
                //value.Replace(".", "").Replace("-", "").Replace("/", "").Replace("(", "").Replace(")", "").Replace(" ", "");
        }

        public static string MaskDocumento(this string value)
        {
            Int64 doc;

            if (Int64.TryParse(value, out doc))
            {
                if (value.Length == 11)
                    return doc.ToString(@"000\.000\.000\-00");

                if (value.Length == 14)
                    return doc.ToString(@"00\.000\.000\/0000\-00");

                return value;
            }
            else
                return value;
        }

        public static string ApplyMask(this string source, string mask)
        {
            if (string.IsNullOrEmpty(source))
                return source;

            MaskedTextProvider maskProvider = new MaskedTextProvider(mask);
            try
            {

                maskProvider.Set(source);
                return maskProvider.ToDisplayString();
            }
            catch
            {
                return source;
            }
            finally
            {
                maskProvider = null;
            }
        }

        
        public static string ToCompetenciaFormatada(this string source)
        {
            if (string.IsNullOrEmpty(source))
                return source;

            if (source.Length != 6)
                return source;

            return string.Format("{0}/{1}", source.Substring(4), source.Substring(0, 4));
        }

        public static string ToCompetenciaDB(this string source)
        {
            if (string.IsNullOrEmpty(source))
                return source;

            if (source.Length < 6)
                return source;

            source = source.RemoveMask();

            return string.Format("{0}{1}", source.Substring(2,4), source.Substring(0, 2));
        }

        public static decimal ToDecimalDefault(this string source, decimal defaultValue = 0)
        {
            decimal val;

            if (decimal.TryParse(source, out val))
                return val;

            return defaultValue;
        }

        public static Int64 ToInt64(this string source)
        {
            Int64 val;

            if (Int64.TryParse(source, out val))
                return val;

            return 0;
        }
    }
}

