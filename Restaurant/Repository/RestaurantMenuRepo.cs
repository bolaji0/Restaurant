using Restaurant.Data;
using Restaurant.Models;

namespace Restaurant.Repository
{
    public class RestaurantMenuRepo : IRestaurantMenuRepo
    {
        private readonly AppDbContext _context;
        public RestaurantMenuRepo(AppDbContext context)
        {
            _context = context;
        }

        public void Create(RestaurantMenus menu)
        {
            _context.menus.Add(menu);
        }

        public void Delete(RestaurantMenus menu)
        {
            _context.menus.Remove(menu);
        }

        public IEnumerable<RestaurantMenus> GetAll()
        {
           return _context.menus;
        }

        public RestaurantMenus GetById(int id)
        {
            return _context.menus.Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(RestaurantMenus menu)
        {
            _context.menus.Update(menu);
        }
    }
}
