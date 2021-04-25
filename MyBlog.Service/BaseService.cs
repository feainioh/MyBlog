using MyBlog.IRepository;
using MyBlog.IService;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MyBlog.Service
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class, new()
    {
        //从子类的构造函数中传入
        protected IBaseRepository<TEntity> _iBaseRepository;
        public async Task<bool> CreateAysnc(TEntity entity)
        {
            return await _iBaseRepository.CreateAysnc(entity);
        }

        public async Task<bool> DeleteAysnc(int id)
        {
            return await _iBaseRepository.DeleteAysnc(id);
        }

        public async Task<bool> EditAysnc(TEntity entity)
        {
            return await _iBaseRepository.EditAysnc(entity);
        }

        public  async Task<TEntity> FindAysnc(int id)
        {
            return await _iBaseRepository.FindAysnc(id);
        }

        public async Task<List<TEntity>> QueryAysnc()
        {
            return await _iBaseRepository.QueryAysnc();
        }

        public async Task<List<TEntity>> QueryAysnc(Expression<Func<TEntity, bool>> func)
        {
            return await _iBaseRepository.QueryAysnc(func);
        }

        public async Task<List<TEntity>> QueryAysnc(int page, int size, RefAsync<int> total)
        {
            return await _iBaseRepository.QueryAysnc(page, size, total);
        }

        public async Task<List<TEntity>> QueryAysnc(Expression<Func<TEntity, bool>> func, int page, int size, RefAsync<int> total)
        {
            return await _iBaseRepository.QueryAysnc(func, page, size, total);
        }
    }
}
