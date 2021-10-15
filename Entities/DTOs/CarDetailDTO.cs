using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDTO
    {
       // public int CarId { get; set; }
       // public int BrandId { get; set; }
        public string ModelName { get; set; }
        public string BrandName { get; set; }
        public string Description { get; set; }
        public int DailyPrice { get; set; }     
    }
}
