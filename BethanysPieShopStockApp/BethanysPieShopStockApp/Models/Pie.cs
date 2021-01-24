using System;
namespace BethanysPieShopStockApp.Models
{
    public class Pie
    {
        private Guid _id;
        private string _pieName;
        private string _description;
        private double _price;
        private string _imageUrl;
        private bool _inStock;



        public Pie()
        {
        }

        public Guid Id { get => _id; set => _id = value; }
        public string PieName { get => _pieName; set => _pieName = value; }
        public string Description { get => _description; set => _description = value; }
        public double Price { get => _price; set => _price = value; }
        public string ImageUrl { get => _imageUrl; set => _imageUrl = value; }
        public bool InStock { get => _inStock; set => _inStock = value; }
    }
}
