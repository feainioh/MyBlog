using MyBlog.IRepository;
using MyBlog.IService;
using MyBlog.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Service
{
    public  class WriterInfoService:BaseService<WriterInfo>,IWriterInfoService
    {
        private readonly IWriterInfoRepository _iWriterInfoRespository;
        public WriterInfoService(IWriterInfoRepository writerInfoRepository)
        {
            base._iBaseRepository = writerInfoRepository;
            _iWriterInfoRespository = writerInfoRepository;
        }
    }
}
