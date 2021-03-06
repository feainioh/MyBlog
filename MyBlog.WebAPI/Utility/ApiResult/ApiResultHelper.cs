using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.WebAPI.Utility.ApiResult
{
    public class ApiResultHelper
    {
        public static ApiResult Success(dynamic data)
        {
            return new ApiResult
            {
                Code = 200,
                Data=data,
                Msg ="操作成功",
                Total=0
            };
        }


        public static ApiResult Success(dynamic data, RefAsync<int> total)//分页
        {
            return new ApiResult()
            {
                Code=200,
                Data=data,
                Msg="操作成功",
                Total=total
            };
        }
        public static ApiResult Error(string msg)
        {
            return new ApiResult
            {
                Code = 500,
                Data = null,
                Msg = msg,
                Total = 0
            };
        }
    }
}
