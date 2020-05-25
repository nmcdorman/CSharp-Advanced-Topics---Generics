﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Advanced_Topics
{
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }

    }
}
