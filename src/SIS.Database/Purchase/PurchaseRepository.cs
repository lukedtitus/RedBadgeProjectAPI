﻿using AutoMapper;
using RedStarter.Database.Contexts;
using RedStarter.Database.DataContract.Purchase;
using RedStarter.Database.Entities.Purchase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.Purchase
{
    public class PurchaseRepository : IPurchaseRepository
    {
        private readonly SISContext _context;
        private readonly IMapper _mapper;

        public PurchaseRepository(SISContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreatePurchase(PurchaseCreateRAO rao)
        {
            var entity = _mapper.Map<PurchaseEntity>(rao);

            await _context.PurchaseTableAccess.AddAsync(entity);

            return await _context.SaveChangesAsync() == 1;
        }

    }
}