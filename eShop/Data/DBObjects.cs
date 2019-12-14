using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShop.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace eShop.Data {
    public class DBObjects {
        public static void Initial(AppDBContent content) {

            if (!content.Category.Any()) {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Phone.Any()) {
                content.AddRange(
                    new Phone
                    {
                        Name = "IPhone 7",
                        ShortDescription = "Apple iPhone 7 128GB White",
                        LongDescription = "4.7 Inch Retina HD display \nIP67 water and dust resistant (maximum depth of 1 metre up to 30 minutes)\n12MP camera and 4K video and 7MP FaceTime HD camera with Retina Flash\nTouch ID for secure authentication and Apple Pay\nA10 Fusion chip\niOS 12 with Screen Time, Group FaceTime, and even faster performance",
                        Image = "https://hotline.ua/img/tx/157/157995082_s265.jpg",
                        Price = 400,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Iphone"]
                    },
                    new Phone
                    {
                        Name = "IPhone 8",
                        ShortDescription = "Apple iPhone 8 64GB Black",
                        LongDescription = "https://hotline.ua/img/tx/157/157995130_s265.jpg",
                        Image = "",
                        Price = 500,
                        IsFavourite = false,
                        Available = true,
                        Category = Categories["Iphone"]
                    },
                    new Phone
                    {
                        Name = "IPhone X",
                        ShortDescription = "Apple iPhone X 64 GB Space Grey ",
                        LongDescription = "5.8 Inch Super Retina display (OLED) with HDR\nIP67 water and dust resistant (maximum depth of 1 metre up to 30 minutes)\n12MP dual cameras with dual OIS and 7MP TrueDepth front camera — Portrait mode and Portrait Lighting\nFace ID for secure authentication and Apple Pay\nA11 Bionic with Neural Engine\nWireless charging — works with Qi chargers",
                        Image = "https://hotline.ua/img/tx/158/158046386_s265.jpg",
                        Price = 600,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Iphone"]
                    },
                    new Phone
                    {
                        Name = "Samsung A9",
                        ShortDescription = "",
                        LongDescription = "",
                        Image = "https://hotline.ua/img/tx/183/183321183_s265.jpg",
                        Price = 400,
                        IsFavourite = false,
                        Available = true,
                        Category = Categories["Android"]
                    },
                    new Phone
                    {
                        Name = "Samsung Galaxy S10",
                        ShortDescription = "Samsung Galaxy S10 128 GB Hybrid-SIM  Black",
                        LongDescription = "Smartphone innovation with an infinity-o display: discover an endlessly beautiful, curved-edge screen; with no home button, no notch for the receiver and a simple dot opening for the front camera, the Galaxy S10 gives you an uninterrupted viewing experience\nTrue Vision Camera: with a front camera, 3 rear cameras and the ultra-wide and ultra-zoom lens, the Galaxy S10 lets you shoot every scene just as your eyes see it",
                        Image = "https://s.ek.ua/jpg/1485359.jpg",
                        Price = 500,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Android"]
                    }
                );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> _category;
        public static Dictionary<string, Category> Categories { 
            get {
                if (_category == null) {
                    var list = new Category[] {
                        new Category{ CategoryName =  "Iphone", Descriotion = "Smartphone with IOS" },
                        new Category{ CategoryName = "Android", Descriotion = "Smartphone with Android OS" }
                    };

                    _category = new Dictionary<string, Category>();

                    foreach (Category element in list) {
                        _category.Add(element.CategoryName, element);
                    }
                }

                return _category;
            } 
        }
    }
}
