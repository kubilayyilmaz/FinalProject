﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext: DbContext, new()
    {
        public void Add(TEntity entity)
        {
            //IDisposable Pattern Implementation
            //Using bloğu bittiği anda garbage collector bellekten siler

            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity); //Referansı yakala
                addedEntity.State = EntityState.Added; //Bu aslında eklenecek bir nesne
                context.SaveChanges(); //Ve şimdi ekle
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity); //Referansı yakala
                deletedEntity.State = EntityState.Deleted; //Bu aslında silinecek bir nesne
                context.SaveChanges(); //Ve şimdi ekle
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ?
                    context.Set<TEntity>().ToList() :
                    context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity); //Referansı yakala
                updatedEntity.State = EntityState.Modified; //Bu aslında güncellenecek bir nesne
                context.SaveChanges(); //Ve şimdi ekle
            }
        }
    }
}