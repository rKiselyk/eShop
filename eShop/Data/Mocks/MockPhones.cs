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
                        ShortDescription = "Apple iPhone X 64 GB Space Grey ",
                        LongDescription = "5.8 Inch Super Retina display (OLED) with HDR\nIP67 water and dust resistant (maximum depth of 1 metre up to 30 minutes)\n12MP dual cameras with dual OIS and 7MP TrueDepth front camera — Portrait mode and Portrait Lighting\nFace ID for secure authentication and Apple Pay\nA11 Bionic with Neural Engine\nWireless charging — works with Qi chargers",
                        Image = "https://www.mrphonedeals.com/20496-large_default/apple-iphone-x-256-gb-kosmicheskij-seryj-vosstanovlennyj-diamond.jpg",
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
                        IsFavourite = false,
                        Available = true,
                        Category =  _categoryPhones.AllCategories.Last()
                    },
                    new Phone{
                        Name = "Samsung Galaxy S10",
                        ShortDescription = "Samsung Galaxy S10 128 GB Hybrid-SIM  Black",
                        LongDescription = "Smartphone innovation with an infinity-o display: discover an endlessly beautiful, curved-edge screen; with no home button, no notch for the receiver and a simple dot opening for the front camera, the Galaxy S10 gives you an uninterrupted viewing experience\nTrue Vision Camera: with a front camera, 3 rear cameras and the ultra-wide and ultra-zoom lens, the Galaxy S10 lets you shoot every scene just as your eyes see it",
                        Image = "https://i.allo.ua/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/i/m/image_product_key_visual_beyond_s10__product_image_black_181211_sm_g975_galaxys10_.jpg",
                        Price = 500,
                        IsFavourite = true,
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
