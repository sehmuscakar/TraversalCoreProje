using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfRezervationDal : GenericRepository<Rezervation>, IRezervationDal
    {
        public List<Rezervation> GetListWithRezervationByAccepted(int id)
        {
            throw new NotImplementedException();
        }

        public List<Rezervation> GetListWithRezervationByPrevious(int id)
        {
            throw new NotImplementedException();
        }

        public List<Rezervation> GetListWithRezervationByWaitAprroval(int id)
        {
            throw new NotImplementedException();
        }
    }
}
