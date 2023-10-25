// https://cloud.google.com/appengine/docs/flexible/custom-runtimes/build#listening_to_port_8080
// code from: https://github.com/GoogleCloudPlatform/getting-started-dotnet/blob/master/HelloWorld/Program.cs

static class ProgramExtensions
{
    // Google App Engine sets the PORT environment variable
		// this ensures we are listening to the correct PORT
    public static IWebHostBuilder UsePortEnvironmentVariable(this IWebHostBuilder builder)
    {
        string port = Environment.GetEnvironmentVariable("PORT");
        if (!string.IsNullOrEmpty(port))
        {
            builder.UseUrls($"http://0.0.0.0:{port}");
        }
        return builder;
    }
}