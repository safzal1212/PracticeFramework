using PracticeFramework.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFramework.Services
{
    public interface IHelloWorld
    {
        IEnumerable<HelloWorldViewModel> Get();

        HelloWorldViewModel GetById(int id);

        bool Add(HelloWorldViewModelReq model);

        bool Update(HelloWorldViewModelReq model);

        int Delete(int id);
    }
}
