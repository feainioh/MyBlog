using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Model
{
    public class WriterInfo : BaseId
    {
        [SugarColumn(ColumnDataType = "nvarchar(20)")]
        public string Name { get; set; }

        [SugarColumn(ColumnDataType = "nvarchar(20)")]
        public string UserName { get; set; }
        [SugarColumn(ColumnDataType = "nvarchar(100)")]
        public string UserPwd { get; set; }
    }
}
