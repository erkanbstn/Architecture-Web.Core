﻿using System.Linq.Expressions;

namespace Layers.Service.Services
{
    public interface IRepositoryService<T> where T : class
    {
        Task InsertAsync(T t);
        Task DeleteAsync(T t);
        Task DeleteAllAsync(List<T> t);
        Task ChangeStatusAsync(T t);
        Task ChangeStatusAllAsync(List<T> t);
        Task UpdateAsync(T t);
        Task<T> GetByIdAsync(int id);
        Task<List<T>> ToListAsync();
        Task<List<T>> ToListByFilterAsync(Expression<Func<T, bool>> filter);
    }
}
