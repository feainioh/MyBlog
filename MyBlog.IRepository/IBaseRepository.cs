using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.IRepository
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IBaseRepository<TEntity> where TEntity:class,new()
    {
        Task<bool> CreateAysnc(TEntity entity);
        Task<bool> DeleteAysnc(int id);
        Task<bool> EditAysnc(TEntity entity);
        Task<TEntity> FindAysnc(int id);
        /// <summary>
        /// 查询全部数据
        /// </summary>
        /// <returns></returns>
        Task<List<TEntity>> QueryAysnc();

        /// <summary>
        /// 自定义条件查询
        /// </summary>
        /// <param name="func"></param>
        /// <returns></returns>
        Task<List<TEntity>> QueryAysnc(Expression<Func<TEntity,bool>> func);

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        Task<List<TEntity>> QueryAysnc( int page,int size,RefAsync<int> total);

        /// <summary>
        /// 自定义条件分页查询
        /// </summary>
        /// <param name="func"></param>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        Task<List<TEntity>> QueryAysnc(Expression<Func<TEntity, bool>> func,int page,int size,RefAsync<int> total);

    }
}
