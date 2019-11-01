using PracticeFramework.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFramework.Services
{
    public interface IPracticeFramework
    {
        IEnumerable<PracticeFrameworkViewModel> Get();
        PracticeFrameworkViewModel GetById(int id);
        bool Add(PracticeFrameworkViewModel pfViewModel);
        bool Update(PracticeFrameworkViewModel pfViewModel);
        int Delete(int id);
    }
}
