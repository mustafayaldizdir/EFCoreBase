using EFCoreBase.Application.Dto.Feature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreBase.Application.Dto.Product
{
    public class ProductCreateDto
    {
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public string UserId { get; set; }
        public string Picture { get; set; }
        public DateTime CreatedDate { get; set; }
        public FeatureDto Feature { get; set; }
        public string CategoryId { get; set; }

    }
}
