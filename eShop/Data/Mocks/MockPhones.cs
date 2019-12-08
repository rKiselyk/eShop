using eShop.Data.Interfaces;
using eShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Data.Mocks {
    public class MockPhones : IAllPhones {
        private readonly IPhonesCategory _categoryPhones = new MockCategory();

        public IEnumerable<Phone> Phones {
            get {
                return new List<Phone> {
                    new Phone{
                        Name = "IPhone 7",
                        ShortDescription = "Apple iPhone 7 128GB White",
                        LongDescription = "4.7 Inch Retina HD display \nIP67 water and dust resistant (maximum depth of 1 metre up to 30 minutes)\n12MP camera and 4K video and 7MP FaceTime HD camera with Retina Flash\nTouch ID for secure authentication and Apple Pay\nA10 Fusion chip\niOS 12 with Screen Time, Group FaceTime, and even faster performance",
                        Image = "https://static.svyaznoy.ru/upload/iblock/6f7/iphone7_2up_matblk_us-en-print-tsgep.jpg",
                        Price = 400,
                        IsFavourite = true,
                        Available = true, 
                        Category =  _categoryPhones.AllCategories.First() 
                    },
                    new Phone{
                        Name = "IPhone 8",
                        ShortDescription = "Apple iPhone 8 64GB Black",
                        LongDescription = "",
                        Image = "",
                        Price = 500,
                        IsFavourite = false,
                        Available = true,
                        Category =  _categoryPhones.AllCategories.First()
                    },
                    new Phone{
                        Name = "IPhone X",
                        ShortDescription = "",
                        LongDescription = "",
                        Image = "",
                        Price = 600,
                        IsFavourite = true,
                        Available = true,
                        Category =  _categoryPhones.AllCategories.First()
                    },
                    new Phone{
                        Name = "Samsung A9",
                        ShortDescription = "",
                        LongDescription = "",
                        Image = "",
                        Price = 400,
                        IsFavourite = true,
                        Available = true,
                        Category =  _categoryPhones.AllCategories.Last()
                    },
                    new Phone{
                        Name = "Samsung Galaxy S10",
                        ShortDescription = "",
                        LongDescription = "",
                        Image = "https://i.allo.ua/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/i/m/image_product_key_visual_beyond_s10__product_image_black_181211_sm_g975_galaxys10_.jpg",
                        Price = 500,
                        IsFavourite = false,
                        Available = true,
                        Category =  _categoryPhones.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Phone> getFavoritePhones { get; set; }

        public Phone getObjectPhone(int carId) {
            throw new NotImplementedException();
        }
    }
}
