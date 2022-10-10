using Microsoft.EntityFrameworkCore;
using My_Ecommerce.DBContext;
using My_Ecommerce.Models.PracticeModel;

namespace My_Ecommerce.Repository
{
    public class MovieRepository
    {
        //private EcommerceDbContext _dbContext = new EcommerceDbContext();
        private EcommerceDbContext _dbContext;

        public MovieRepository(EcommerceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ICollection<Movie>> GetDataList()
        {
            return await _dbContext.Movie.ToListAsync();
        }

        public async Task<Movie> GetData(long id)
        {
            var datalist = await _dbContext.Movie.ToListAsync();
            var singleData = (datalist.Count > 0) ? datalist.FirstOrDefault(c => c.Id == id) : new Movie();
            return singleData;
        }

    }
}
