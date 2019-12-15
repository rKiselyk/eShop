using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Data.Models {
    public class Order {
        [BindNever]
        public int Id { get; set; }

        [Display(Name = "Enter Name")]
        [StringLength(5)]
        [Required(ErrorMessage ="Name lenght must be > 5")]
        public string Name { get; set; }

        [Display(Name = "Enter Surname")]
        [StringLength(15)]
        [Required(ErrorMessage = "Name lenght must be > 5")]
        public string Surname { get; set; }

        [Display(Name = "Enter Adress")]
        [StringLength(5)]
        [Required(ErrorMessage = "Name lenght must be > 5")]
        public string Adress { get; set; }

        [Display(Name = "Enter Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(5)]
        [Required(ErrorMessage = "Name lenght must be > 5")]
        public string Email { get; set; }

        [Display(Name = "Enter Phone")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(5)]
        [Required(ErrorMessage = "Name lenght must be > 5")]
        public string Phone { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
