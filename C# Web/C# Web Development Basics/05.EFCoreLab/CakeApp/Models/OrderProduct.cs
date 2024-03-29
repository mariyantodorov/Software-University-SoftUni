﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CakeApp.Models
{
    public class OrderProduct : BaseModel<int>
    {
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
