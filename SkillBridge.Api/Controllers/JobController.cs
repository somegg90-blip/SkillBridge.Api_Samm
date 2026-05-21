using Microsoft.AspNetCore.Mvc;
namespace SkillBridge.Api.Controllers;
using Microsoft.EntityFrameworkCore;
using SkillBridge.Api.Entities;


    [ApiController]
    [Route("[controller]")]

    public class JobController : ControllerBase
{
    private readonly IJobRepository _jobRepository;
    public JobController(IJobRepository jobRepository)
    {
        _jobRepository = jobRepository;
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetJobById(int id)
    {
        var job = await _jobRepository.GetJobByIdAsync(id);
        if (job == null)
        {
            return NotFound();
        }
        return Ok(job);
    }
}
