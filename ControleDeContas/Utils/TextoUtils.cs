using System.Globalization;
using System.Text;

namespace ControleDeContas.Utils
{
    internal class TextoUtils
    {
        public static string RemoverAcentos(string texto)
        {
            string normalizado = texto.Normalize(NormalizationForm.FormD);
            return new string(normalizado.Where(c => CharUnicodeInfo.GetUnicodeCategory(c)
                != UnicodeCategory.NonSpacingMark).ToArray());
        }

        public static string Capitalizar(string texto)
        {
            texto = RemoverAcentos(texto.ToLower());
            return char.ToUpper(texto[0]) + texto.Substring(1);
        }
    }
}


