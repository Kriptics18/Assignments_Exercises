using EntityFramework.Core.Interfaces.Services;
using EntityFramework.Core.Models.RequestModel;
using EntityFramework.Infrastructure.Services;

namespace EntityFramework.Presentation.UI;

public class ManageDepartment
{
    private DepartmentService _departmentService = new DepartmentService();
    
    private void AddDepartment()
    {
        DepartmentRequestModel departmentRequestModel = new DepartmentRequestModel();
        Console.WriteLine("Please enter department name");
        departmentRequestModel.DepartmentName = Console.ReadLine();
        Console.WriteLine("Please enter department location");
        departmentRequestModel.Location = Console.ReadLine();
        Console.WriteLine(_departmentService.AddDepartment(departmentRequestModel));
    }

    private void DeleteDepartment()
    {
        Console.WriteLine("Enter Id =>");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(_departmentService.DeleteDepartment(id));
    }

    private void UpdateDepartment()
    {
        DepartmentRequestModel departmentRequestModel = new DepartmentRequestModel();
        Console.WriteLine("Enter Id =>");
        int Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Name =>");
        departmentRequestModel.DepartmentName = Console.ReadLine();
        Console.WriteLine("Enter Location =>");
        departmentRequestModel.Location = Console.ReadLine();
        Console.WriteLine(_departmentService.UpdateDepartment(Id, departmentRequestModel));
    }

    private void PrintAllDepartment()
    {
        var departments = _departmentService.GetAllDepartments();
        foreach (var department in departments)
        {
            Console.WriteLine(department.Id + "\t" + department.DepartmentName + "\t" + department.Location);
        }
    }

    private void GetDepartmentById()
    {
        Console.WriteLine("Enter Department Id =>");
        int id = Convert.ToInt32(Console.ReadLine());
        var department = _departmentService.GetById(id);
        Console.WriteLine(department.DepartmentName + "\t" + department.Location);
    }



    public void Run()
    {
        PrintAllDepartment();
    }

    public void TestRunAllOps() {

        //using a loop to test all operations
        while (true) {
            Console.WriteLine("Current List of Departments:");
            PrintAllDepartment();
            Console.WriteLine("1. Add Department");
            Console.WriteLine("2. Delete Department By Id");
            Console.WriteLine("3. Update Department By Id");
            Console.WriteLine("4. Get Department By Id");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice =>");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice) {
                case 1:
                    AddDepartment();
                    break;
                case 2:
                    DeleteDepartment();
                    break;
                case 3:
                    UpdateDepartment();
                    break;
                case 4:
                    GetDepartmentById();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}