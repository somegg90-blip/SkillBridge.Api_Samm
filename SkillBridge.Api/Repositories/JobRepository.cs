public class JobRepository : IJobRepository
{
    public async Task<IEnumerable<JobDto>> GetJobsListAsync()
    {
        var jobList = new List<JobDto>
        {
            new JobDto
            {
                Id = 1,
                Name = "Software Engineer",
                Description = "Develop and maintain software applications.",
                MinSalary = 60000,
                MaxSalary = 120000,
                Company = "Tech Company A",
                Location = "New York, NY"
            },
            new JobDto
            {
                Id = 2,
                Name = "Data Scientist",
                Description = "Analyze and interpret complex data to help companies make decisions.",
                MinSalary = 70000,
                MaxSalary = 130000,
                Company = "Tech Company B",
                Location = "San Francisco, CA"
            }
        };

        return jobList;
    }
}