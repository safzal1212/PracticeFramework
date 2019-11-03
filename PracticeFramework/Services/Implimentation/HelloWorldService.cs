using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PracticeFramework.Models;
using PracticeFramework.Models.Request;

namespace PracticeFramework.Services.Implimentation
{
    public class HelloWorldService : IHelloWorld
    {
        #region dependencies
        private readonly TestDBEntities _db;
        #endregion

        #region constructor
        public HelloWorldService(TestDBEntities db)
        {
            _db = db;
        }
        #endregion

        public bool Add(HelloWorldViewModelReq model)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<HelloWorldViewModel> Get()
        {
            throw new NotImplementedException();
        }

        public HelloWorldViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(HelloWorldViewModelReq model)
        {
            throw new NotImplementedException();
        }
    }
}