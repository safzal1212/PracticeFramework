using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PracticeFramework.Models;
using PracticeFramework.Models.Response;

namespace PracticeFramework.Services.Implimentation
{
    public class PracticeFrameworkService : IPracticeFramework
    {

        #region dependencies

        private readonly TestDBEntities _db;

        #endregion

        #region constructor

        public PracticeFrameworkService(TestDBEntities db)
        {
            _db = db;
        }

        #endregion

        public bool Add(PracticeFrameworkViewModel pfViewModel)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            var modelToDelete = _db.tblTests.Find(id);

            var practiceModel = new tblTest();

            if (modelToDelete != null)
            {
                practiceModel = _db.tblTests.Remove(modelToDelete);
            }

            _db.SaveChanges();
            return practiceModel.Id;
        }

        public IEnumerable<PracticeFrameworkViewModel> Get()
        {
            var pfVMList = _db.tblTests.ToList();

            return PracticeFrameworkViewModel.From(pfVMList);
        }

        public PracticeFrameworkViewModel GetById(int id)
        {
            var pfvm = _db.tblTests.Where(x => x.Id == id).FirstOrDefault();

            return PracticeFrameworkViewModel.From(pfvm);
        }

        public bool Update(PracticeFrameworkViewModel pfViewModel)
        {
            var pfvm = _db.tblTests.Find(pfViewModel.id);

            if (pfvm !=null)
            {
                pfvm.Description = pfViewModel.description;
            }

            _db.SaveChanges();
            return true;
        }
    }
}