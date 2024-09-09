Sure! Here's a simple example of how to create a small HTTP server in C# using the `HttpListener` class:

1. **Create a new Console Application** in Visual Studio.

2. **Add the necessary namespaces**:
```csharp
using System;
using System.Net;
using System.Text;
using System.Threading.Tasks;
```

3. **Write the server code**:
```csharp
class Program
{
    static void Main(string[] args)
    {
        // Create a new HttpListener instance
        HttpListener listener = new HttpListener();
        listener.Prefixes.Add("http://localhost:8080/");
        listener.Start();
        Console.WriteLine("Listening...");

        // Handle requests asynchronously
        Task.Run(() =>
        {
            while (true)
            {
                HttpListenerContext context = listener.GetContext();
                HttpListenerRequest request = context.Request;
                HttpListenerResponse response = context.Response;

                // Create a response
                string responseString = "<html><body>Hello, World!</body></html>";
                byte[] buffer = Encoding.UTF8.GetBytes(responseString);
                response.ContentLength64 = buffer.Length;
                System.IO.Stream output = response.OutputStream;
                output.Write(buffer, 0, buffer.Length);
                output.Close();
            }
        });

        // Keep the server running
        Console.WriteLine("Press Enter to stop the server.");
        Console.ReadLine();
        listener.Stop();
    }
}
```

4. **Run the server**: Press `F5` in Visual Studio to start the server.

5. **Access the server**: Open your web browser and go to `http://localhost:8080/`. You should see "Hello, World!" displayed.

This is a basic example to get you started. If you need more advanced features, you can explore frameworks like ASP.NET Core for more robust solutions.

Would you like any additional help with this?

Sursă: conversație cu Copilot. 9/9/2024
(1) Create a Simple HTTP Server | Visual C#.NET. https://www.youtube.com/watch?v=GLHQiQIVwNQ.
(2) Create a Web Server using C# - Part 1. https://www.youtube.com/watch?v=Egft81lOgaQ.
(3) How To Create a Simple HTTP Server with Node.js. https://www.youtube.com/watch?v=TrofE5tDRag.
(4) C# Simple Http Server - coding.vision. https://codingvision.net/c-simple-http-server.
(5) dotnet/WatsonWebserver - GitHub. https://github.com/dotnet/WatsonWebserver.
(6) C# Simple Http Server - coding.vision. https://bing.com/search?q=create+a+small+http+server+in+c%23.
(7) A very simple, small and lightweight http file server in C#. https://github.com/mbuchetics/SimpleWebServer.
(8) undefined. http://127.0.0.1/.
(9) undefined. http://127.0.0.1/anyfile.html.