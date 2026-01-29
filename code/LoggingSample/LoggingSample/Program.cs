using System;
using Serilog;

class Program
{
    static void Main()
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .WriteTo.File("logs/app.log", rollingInterval: RollingInterval.Day)
            .CreateLogger();

        try
        {
            Log.Information("Application started");

            int x = 10;
            int y = 0;

            int result = x / y; // error intencional
        }
        catch (Exception ex)
        {
            Log.Error(ex, "An exception occurred while performing division");
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }
}
