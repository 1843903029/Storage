using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL.LLJ
{
  public  class admManger
    {
        public static IQueryable Rogin(Admin a)
        {
            return DAL.LLJ.admService.Rogin(a);
        }
    }
}
