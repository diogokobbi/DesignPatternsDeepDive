using System;
using CreationalPatterns.Builder;
namespace CreationalPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Builder Pattern */
            // var htmlString = WithoutBuilder.BuildHtmlList(new string[] {"Hello","World!"});
            // Console.WriteLine(htmlString);
            // Console.ReadLine();

            var htmlBuilder = new HtmlBuilder("ul");
            htmlBuilder.AddChild("li", "Hello");
            htmlBuilder.AddChild("li", "World!");
            Console.WriteLine(htmlBuilder.ToString());
            Console.ReadLine();
        }
    }
}
