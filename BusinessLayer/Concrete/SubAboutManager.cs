using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class SubAboutManager:ISubAboutService
    {
        ISubAboutDal _subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }

        public void TAdd(EntityLayer.Concrete.SubAbout t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(EntityLayer.Concrete.SubAbout t)
        {
            throw new NotImplementedException();
        }

        public EntityLayer.Concrete.SubAbout TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<EntityLayer.Concrete.SubAbout> TGetList()
        {
            return _subAboutDal.Getlist();
        }

        public void TUpdate(EntityLayer.Concrete.SubAbout t)
        {
            throw new NotImplementedException();
        }
    }
}
