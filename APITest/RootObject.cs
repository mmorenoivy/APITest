using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITest
{
    public class RootObject
    {
                  
        public class Promotion
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
         
        }

        public class Root
        {
            public int CategoryId { get; set; }
            public string Name { get; set; }
            
            public bool CanRelist { get; set; }
            
            public bool IsFreeToRelist { get; set; }
      //      public List<Promotion> Promotions { get; set; }
           
        }
    }
}
