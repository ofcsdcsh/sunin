using System.Text;

class Program
{
    static void Main()
    {
        // Create a new instance of StringBuilder
        StringBuilder html = new StringBuilder();

        // Append various parts of the HTML content
        html.Append("<html>");
        html.Append("<head><title>My Page</title></head>");
        html.Append("<body>");
        html.Append("<h1>Hello, World!</h1>");
        html.Append("<p>This is a paragraph.</p>");
        html.Append("</body>");
        html.Append("</html>");

        // Convert the StringBuilder content to a string
        string result = html.ToString();

        // Output the result
        System.Console.WriteLine(result);
    }
}
