using DummyProject.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DummyProject.Controllers
{
    [Route("apigateway/api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly DummyAuthDbContext context;

        public AuthController(DummyAuthDbContext context)
        {
            this.context = context;
        }



        [HttpPost("employeeinfo")]
        public async Task<IActionResult> Employee([FromBody] EmployeeRequest employee)
        {
            if (employee != null)
            {
                var employees = await context.MisUsers.FirstOrDefaultAsync(x => x.UserName == employee.Username && x.Password == employee.Password);
                if (employees != null)
                {
                    var employeeInfo = await context.EmployeeInfos.FirstOrDefaultAsync(x => x.EmailAddress == employee.Email);
                    if (employeeInfo != null)
                    {
                        EmployeeResponse response = new EmployeeResponse
                        {
                            StatusCode = "200",
                            Message = "Success",
                            Data = new List<EmployeeInfo> { employeeInfo },
                            Error = "False"
                        };
                        return Ok(response);
                    }
                }
            }
            return NotFound(new { StatusCode = "103", Message = "Fail", Error = "True" });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LogRequest logRequest)
        {
            if (logRequest != null)
            {
                var user = await context.MisUsers.FirstOrDefaultAsync(x => x.UserName == logRequest.Username && x.Password == logRequest.Password);
                if (user != null)
                {
                    return Ok(new LoginResponse { Status = "Success" });
                }
            }

            return NotFound(new LoginResponse { Status = "Fail" });
        }
    }
}
