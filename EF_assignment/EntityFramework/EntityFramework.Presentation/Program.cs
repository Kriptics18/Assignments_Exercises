// See https://aka.ms/new-console-template for more information

using EntityFramework.Presentation.UI;
using Serilog;
using Serilog.Core;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.File("logs/mylog.txt")
    .CreateLogger();
Log.Information("Application Started");
Log.Debug("This is a debug message");






try {
    ManageEmployee manageEmployee = new ManageEmployee();
    manageEmployee.Run();
    ManageDepartment manageDepartment = new ManageDepartment();
    manageDepartment.Run();
    manageDepartment.TestRunAllOps();
} catch (Exception ex) {
    //Log.Warning("An unexpected warning occurred");
    //Log.Error("An error occurred while processing");
    //Log.Fatal("A fatal error has occurred");

    // show appropriate message to the user based on the exception

    if (ex is FormatException) {
        Log.Error("Invalid input");
    } else if (ex is InvalidOperationException) {
        Log.Error("Invalid operation");
    } else {
        Log.Error(ex, "An unexpected error occurred while processing");
    }

}
