using Microsoft.AspNetCore.Mvc.Rendering;
using ZombieParty.Models;

namespace ZombieParty.Services
{
    public interface IZombieTypeService : IServiceBaseAsync<ZombieType>
    {
        IEnumerable<SelectListItem> ListZombieTypeDisponible();
    }
}
