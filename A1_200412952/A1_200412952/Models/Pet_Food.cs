using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A1_200412952.Models
{
    public class Pet_Food
    {
        public virtual int Id { get; set; }

        public virtual Decimal Price { get; set; }
        public virtual String Name { get; set; }

        public virtual String Description { get; set; }

        public virtual String Nutritional_Information { get; set; }

        public virtual Decimal Weight { get; set; }

        public virtual String Brand { get; set; }

        public virtual String Type_Of_Animal { get; set; }
    }
}
