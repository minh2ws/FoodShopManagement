﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShopManagement_WF.Presenter
{
    interface IProductDetail
    {
        bool UpdateProduct(TblProductsDTO dto);
    }
}
