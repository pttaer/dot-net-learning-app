using DotNetLearningApp.Services.SchoolService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetLearningApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SchoolController : ControllerBase
    {
        private readonly ISchool _schoolService;

        public SchoolController(ISchool schoolService)
        {
            _schoolService = schoolService;
        }

        [HttpGet]
        public async Task<ActionResult<List<School>>> GetAllSchool()
        {
            return Ok(_schoolService.GetAllSchool());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<School>> GetOneSchool(int id)
        {
            var result = _schoolService.GetOneSchool(id);

            if (result is null)
            {
                return NotFound("No correct school found");
            }

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<int>> AddSchool(School school)
        {
            _schoolService.AddSchool(school);

            return CreatedAtAction(nameof(AddSchool), school.Id);
        }
        
        [HttpPut("{id}")]
        public async Task<ActionResult<List<School>>> EditSchool(int id, School request)
        {
            var result = _schoolService.EditSchool(id, request);

            if (result is null)
            {
                return NotFound("No correct school found");
            }

            return Ok(result);
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<School>>> DeleteSchool(int id)
        {
            var result = _schoolService.DeleteSchool(id);

            if (result is null)
            {
                return NotFound("No correct school found");
            }

            return Ok(result);
        }
    }
}
