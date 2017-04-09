using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumWebApi.Resource
{
    interface IRepository
    {
        string deleteData(int Id);
        string addData(object obj);
        string getData();
        string editData(int Id);

    }
}
