﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSoftBreak.Models.Entities
{
     public  class OrderDetail: BaseEntity
    {
        public int ProductID { get; set; }
        public int OrderID { get; set; }

        //Relational Properties
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}
