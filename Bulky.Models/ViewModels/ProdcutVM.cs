using Bulky.Models.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Threading.Tasks;
namespace Bulky.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }

        public IEnumerable<SelectListItem> CategoryList { get; set; }

    }
}
