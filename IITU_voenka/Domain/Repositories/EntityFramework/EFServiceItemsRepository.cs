﻿using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using IITU_voenka.Domain.Entities;
using IITU_voenka.Domain.Repositories.Abstract;

namespace IITU_voenka.Domain.Repositories.EntityFramework
{
    public class EFServiceItemsRepository : IServiceItemsRepository
    {
        private readonly AppDbContext context;
        public EFServiceItemsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<ServiceItem> GetServiceItems()
        {
            return context.ServiceItem;
        }

        public ServiceItem GetServiceItemById(Guid id)
        {
            return context.ServiceItem.FirstOrDefault(x => x.Id == id);
        }

        public void SaveServiceItem(ServiceItem entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteServiceItem(Guid id)
        {
            context.ServiceItem.Remove(new ServiceItem() { Id = id });
            context.SaveChanges();
        }
    }
}
