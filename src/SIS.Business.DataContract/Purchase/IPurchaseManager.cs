﻿using RedStarter.Business.DataContract.Purchase.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.DataContract.Purchase
{
    public interface IPurchaseManager
    {
        Task<bool> CreatePurchase(PurchaseCreateDTO dto);
        Task<IEnumerable<PurchaseListItemDTO>> GetPurchases();
    }
}
