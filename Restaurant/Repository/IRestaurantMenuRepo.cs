using Restaurant.Models;

namespace Restaurant.Repository
{
    public interface IRestaurantMenuRepo
    {
        IEnumerable<RestaurantMenus> GetAll();
        RestaurantMenus GetById(int id);
        void Create(RestaurantMenus menu);
        void Update(RestaurantMenus menu);  
        void Delete(RestaurantMenus menu);
        void Save();
    }
}
