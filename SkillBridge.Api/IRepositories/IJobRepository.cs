public interface IJobRepository
{
    Task <IEnumerable<JobDto>> GetJobsListAsync();
    Task<JobDto> GetJobByIdAsync(int id);
}