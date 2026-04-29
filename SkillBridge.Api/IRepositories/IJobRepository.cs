public interface IJobRepository
{
    Task <IEnumerable<JobDto>> GetJobsListAsync();
}