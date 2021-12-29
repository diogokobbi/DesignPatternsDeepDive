using System;
using System.Collections.Generic;
using System.Text;
namespace CreationalPatterns.Builder
{
    public class HtmlBuilder
    {
        private readonly string rootName;
        HtmlElement root = new HtmlElement();
        public HtmlBuilder(string rootName)
        {
            this.rootName = rootName;
            root.Name = rootName;
        }

        public void AddChild(string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            root.Elements.Add(e);
        }

        public override string ToString()
        {
            return root.ToString();
        }

        public void Clear()
        {
            root = new HtmlElement { Name = rootName };
        }
    }
    public class HtmlElement
    {
        public string Name, Text;
        public IList<HtmlElement> Elements = new List<HtmlElement>();
        private const short IndentSize = 2;
        public HtmlElement()
        {
            
        }
        public HtmlElement(string name, string text)
        {
            Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
            Text = text ?? throw new ArgumentNullException(paramName: nameof(text));
        }

        public override string ToString()
        {
            return ToStringImpl(0);
        }

        private string ToStringImpl(int indent)
        {
            var sb = new StringBuilder();
            var i = new string(' ', IndentSize * indent);
            sb.AppendLine($"{i}<{Name}>");
            if(!string.IsNullOrWhiteSpace(Text))
            {
                sb.Append(new string(' ', IndentSize * (indent + 1)));
                sb.AppendLine(Text);
            }

            foreach (var e in Elements)
            {
                sb.Append(e.ToStringImpl(indent + 1));
            }
            sb.AppendLine($"{i}</{Name}>");
            return sb.ToString();
        }
    }
}