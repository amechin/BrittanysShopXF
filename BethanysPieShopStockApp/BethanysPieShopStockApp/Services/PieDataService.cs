using System;
using System.Collections.Generic;
using BethanysPieShopStockApp.Models;

namespace BethanysPieShopStockApp.Services
{
    public class PieDataService : IPieDataService
    {
        public List<Pie> GetAllPies()
        {
            return PieRepository.Pies;
        }

        public void AddPie(Pie pie)
        {
            PieRepository.AddPie(pie);
        }

        public void UpdatePie(Pie pie)
        {
            PieRepository.UpdatePie(pie);
        }
    }
}
