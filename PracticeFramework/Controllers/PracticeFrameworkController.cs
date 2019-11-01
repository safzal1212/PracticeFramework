using PracticeFramework.Models.Response;
using PracticeFramework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PracticeFramework.Controllers
{
    public class PracticeFrameworkController : ApiController
    {
        #region Dependencies

        private readonly IPracticeFramework _practiceFrameWork;

        #endregion


        #region Constructor
        public PracticeFrameworkController(IPracticeFramework practiceFramework)
        {
            _practiceFrameWork = practiceFramework;
        }

        #endregion

        // GET api/<controller>
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Route("api/practiceframework/getall")]
        [HttpGet]
        public IEnumerable<PracticeFrameworkViewModel> GetAll()
        {
            var pfvlst = _practiceFrameWork.Get();

            return pfvlst;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}