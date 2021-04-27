using MyBlog.IRepository;
using MyBlog.IService;
using MyBlog.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Service
{
    public class BlogNewsService:BaseService<BlogNews>,IBlogNewsService
    {
        private readonly IBlogNewsRepository _iBlogNewsRepository;
        public BlogNewsService(IBlogNewsRepository blogNewsRepository)
        {
            base._iBaseRepository = blogNewsRepository;
            _iBlogNewsRepository = blogNewsRepository;
        }
    }
}
