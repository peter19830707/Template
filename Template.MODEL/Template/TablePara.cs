using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.MODEL.Template
{
    public class TablePara
    {
        public string n1 { get; set; }
        public string n2 { get; set; }
    }

    public class CreateTableIn: TablePara
    {
    }
    public class EditTableIn : TablePara
    {
        public long Id { get; set; }
    }
    public class QueryTableOut : TablePara
    {
        public long Id { get; set; }
    }
    public class DeleteTableIn
    {
        public long Id { get; set; }
    }
}
