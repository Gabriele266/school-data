namespace Test;

using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using SchoolData.Controllers;
using SchoolData.Models;

public class StudentControllerTest
{
    private StudentController _studentController;

    public StudentControllerTest()
    {
        var factory = LoggerFactory.Create(b => b.AddConsole());
        var logger = factory.CreateLogger<StudentController>();
        this._studentController = new StudentController(logger);
    }

    [Fact]
    public void ShouldReturnAllStudents()
    {
        IActionResult result = _studentController.Index();
        Assert.IsType<ViewResult>(result);

        ViewResult v = result as ViewResult;

        Assert.IsType<Student[]>(v.ViewData.Model);
        Student[] students = v.ViewData.Model as Student[];
    }
}
