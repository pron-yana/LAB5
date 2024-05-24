using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace LAB5;

[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    private List<Student> _students;

    public StudentController()
    {
        _students = new List<Student>()
        {
            new Student("is-23fiot-22-106", "Yana", "Pron`", 2, "IS-23"),
            new Student("is-23fiot-22-93", "Illia", "Zhurikov", 2,"IS-23" ),
            new Student("is-23fiot-22-98", "Artem", "Marchenko", 2,"IS-23"),
            new Student("is-23fiot-22-101", "Kateryna", "Myronets", 2,"IS-23" ),
            new Student("is-23fiot-22-112", "Myroslav", "Shymkiv", 2,"IS-23"),
        };
    }
    

    [HttpGet("{login}")]
    public IActionResult GetByLogin([FromRoute] string login)
    {
        var student = _students.FirstOrDefault(st => st.Login == login);
        return Ok(student);
    }
}