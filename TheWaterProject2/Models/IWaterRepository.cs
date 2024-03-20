namespace TheWaterProject2.Models
{
    public interface IWaterRepository
    {
        public IQueryable<Project> Projects {  get; }
    }
}
