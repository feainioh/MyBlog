using MyBlog.IRepository;
using MyBlog.Model;
using SqlSugar;
using SqlSugar.IOC;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Repository
{
    public class BaseRepository<TEntity> : SimpleClient<TEntity>, IBaseRepository<TEntity> where TEntity : class, new()
    {
        public BaseRepository(ISqlSugarClient context=null):base(context)
        {
            base.Context = DbScoped.Sugar;
            //创建数据库
            base.Context.DbMaintenance.CreateDatabase();
            //创建表
            base.Context.CodeFirst.InitTables(
                typeof(BlogNews),
                typeof(TypeInfo),
                typeof(WriterInfo)
                );
        }
        public async Task<bool> CreateAysnc(TEntity entity)
        {
            return await base.InsertAsync(entity);
        }

        public async Task<bool> DeleteAysnc(int id)
        {
            return await base.DeleteByIdAsync(id);
        }

        public async Task<bool> EditAysnc(TEntity entity)
        {
            return await base.UpdateAsync(entity);
        }

        public async Task<TEntity> FindAysnc(int id)
        {
            return await base.GetByIdAsync(id);
        }

        public async Task<List<TEntity>> QueryAysnc()
        {
            return await base.GetListAsync();
        }

        public async Task<List<TEntity>> QueryAysnc(Expression<Func<TEntity, bool>> func)
        {
            return await base.GetListAsync(func);
        }

        public async Task<List<TEntity>> QueryAysnc(int page, int size, RefAsync<int> total)
        {
            return await base.Context.Queryable<TEntity>().ToPageListAsync(page,size,total);
        }

        public async Task<List<TEntity>> QueryAysnc(Expression<Func<TEntity, bool>> func, int page, int size, RefAsync<int> total)
        {
            return await base.Context.Queryable<TEntity>()
                .Where(func)
                .ToPageListAsync(page,size,total);
        }
    }
}
