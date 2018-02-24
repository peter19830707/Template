using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.DAL;
using Template.DAL.Repository;
using Template.MODEL.Common;
using Template.MODEL.Enum;
using Template.MODEL.Template;

namespace Template.BLL
{
    public class TableBLL
    {
        private readonly TableDLL _tbDAL;
        public TableBLL()
        {
            var unitOfWork = new EFUnitOfWork();
            _tbDAL = new TableDLL(unitOfWork);
        }
        /// <summary>
        /// 新增一筆資料
        /// </summary>
        /// <param name="Para"></param>
        /// <param name="MemId"></param>
        public void Create(CreateTableIn Para, int MemId)
        {
            _tbDAL.Create(Para, MemId);
        }
        /// <summary>
        /// 修改一筆資料
        /// </summary>
        /// <param name="Para"></param>
        /// <param name="MemId"></param>
        public void Edit(EditTableIn Para, int MemId)
        {
            if (Para.Id == 0)
                throw new CommonException(ReturnCode.NoTargetId);
            _tbDAL.Edit(Para, MemId);
        }
        /// <summary>
        /// 刪除一筆資料
        /// </summary>
        /// <param name="Para"></param>
        /// <param name="MemId"></param>
        public void Delete(DeleteTableIn Para, int MemId)
        {
            if (Para.Id == 0)
                throw new CommonException(ReturnCode.NoTargetId);
            _tbDAL.Delete(Para, MemId);
        }
        /// <summary>
        /// 取得清單
        /// </summary>
        /// <param name="Para"></param>
        /// <param name="MemId"></param>
        public PageListInfo<TableSimpleOut> GetList(QTableIn Para, int Page, int PageCount)
        {
            return _tbDAL.GetList(Para, Page, PageCount);
        }
        /// <summary>
        /// 取得單筆紀錄
        /// </summary>
        /// <param name="Para"></param>
        /// <param name="MemId"></param>
        public QueryTableOut GetSingle(QTableDetIn Para)
        {
            return _tbDAL.GetSingle(Para);
        }
    }
}
