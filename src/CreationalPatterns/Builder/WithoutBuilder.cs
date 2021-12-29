using System;
using System.Text;
namespace CreationalPatterns.Builder
{
    public static class WithoutBuilder
    {
        public static string BuildHtmlList(string[] words)
        {
            var sb = new StringBuilder();
            sb.Append("<ul>");
            foreach (var word in words)
            {
                sb.AppendFormat($"<li>{word}</li>");
            }
            sb.Append("/<ul>");
            return sb.ToString();
        }
    }
}