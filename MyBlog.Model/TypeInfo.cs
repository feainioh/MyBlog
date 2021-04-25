using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Model
{
    public class TypeInfo:BaseId
    {
        [SugarColumn(ColumnDataType ="nvarchar(16)")]
        public string Name { get; set; }


    }
}
