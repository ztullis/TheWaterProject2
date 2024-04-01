using SQLitePCL;

namespace TheWaterProject2.Models
{
    public class EFWaterRepository : IWaterRepository
    {
        private WaterProjectContext2 _context;
        public EFWaterRepository(WaterProjectContext2 temp) 
        {
            _context = temp;
        }


        public IQueryable<Project> Projects => _context.Projects;
    }
}
