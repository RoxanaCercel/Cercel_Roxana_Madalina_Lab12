using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cercel_Roxana_Madalina_Lab12.Models;
namespace Cercel_Roxana_Madalina_Lab12.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
