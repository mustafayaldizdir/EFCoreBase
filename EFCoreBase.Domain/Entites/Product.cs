using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreBase.Domain.Entites
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int  Stock { get; set; }
        public int CategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsDeleted { get; set; }


    }
}
