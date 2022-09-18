using Microsoft.EntityFrameworkCore;

namespace DataAccess.Base
{
    public class BaseManager
    {

        #region Singleton Contexto
        protected static ApplicationDbContext _context;


        public static ApplicationDbContext contextoSingleton
        {
            get
            {
                if (_context == null)
                    _context = new ApplicationDbContext();
                return _context;
            }
        }

        #endregion
    }
}
