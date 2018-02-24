using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Template.DAL.Repository;
using Template.EF;
using Template.MODEL.Common;
using Template.MODEL.Enum;
using Template.MODEL.Template;

namespace Template.DAL
{
    public class TableDLL
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IRepository<Table_1> _tbrep;
        public TableDLL(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            _tbrep = new Repository<Table_1>(unitOfWork);
        }
        /// <summary>
        /// 新增一筆紀錄
        /// </summary>
        /// <param name="Para"></param>
        /// <param name="MemId"></param>
        public void Create(CreateTableIn Para, int MemId)
        {
            var CreateInfo = _tbrep.GetAll().OrderByDescending(d => d.Id).Take(1).FirstOrDefault();
            var data = new Table_1()
            {
                //實作內容
            };
            _tbrep.Create(data);
            _tbrep.Save();
        }
        /// <summary>
        /// 修改一筆紀錄
        /// </summary>
        /// <param name="Para"></param>
        /// <param name="MemId"></param>
        public void Edit(EditTableIn Para, int MemId)
        {
            var EditInfo = _tbrep.Query(d => d.Id == Para.Id).FirstOrDefault();
            if (EditInfo == null)
                throw new CommonException(ReturnCode.NoFoundTargetData);
            //實作
        }
        /// <summary>
        /// 刪除一筆紀錄
        /// </summary>
        /// <param name="Para"></param>
        /// <param name="MemId"></param>
        public void Delete(DeleteTableIn Para, int MemId)
        {
            var DelInfo = _tbrep.Query(d => d.Id == Para.Id).FirstOrDefault();
            if (DelInfo == null)
                throw new CommonException(ReturnCode.NoFoundTargetData);
            //實作
            _tbrep.Save();
        }
        public PageListInfo<TableSimpleOut> GetList(QTableIn Para, int Page, int PageCount)
        {
            using (var db = new TemplateEntities())
            {
                var result = new PageListInfo<TableSimpleOut>();
                var data = db.Table_1
                           .AsExpandable()
                           .Where(PrmMeeingCondition(Para));
                //實作

                return result;
            }
        }
        private Expression<Func<Table_1, bool>> PrmMeeingCondition(QTableIn Para)
        {
            var Search = PredicateBuilder.New<Table_1>();
            //實作
            return Search;
        }
        public QueryTableOut GetSingle(QTableDetIn Para)
        {
            //實作搜尋_tbrep.Query .... .. FirstOrDefault()
            return new QueryTableOut();
        }
    }
}
