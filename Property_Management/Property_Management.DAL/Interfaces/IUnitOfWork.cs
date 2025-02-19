﻿namespace Property_Management.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
        {
            IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;

            int SaveChanges();

            Task<int> SaveChangesAsync();
        }

}
