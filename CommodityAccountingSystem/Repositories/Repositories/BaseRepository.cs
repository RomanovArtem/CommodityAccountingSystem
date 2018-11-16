using CreateDataBase;

namespace Repositories.Repositories
{
    public class BaseRepository
    {
        protected CASContext dbContext;

        public BaseRepository()
        {
            dbContext = new CASContext();
        }
    }
}
