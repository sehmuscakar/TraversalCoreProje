using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
  public interface IRezervationDal:IGenericDal<Rezervation>
    {
        List<Rezervation> GetListWithRezervationByWaitAprroval(int id);//by:anlamı şuna göre ,onay bekleyenler ,dışardan idi alacaklar 
        List<Rezervation> GetListWithRezervationByAccepted(int id); //kabul edilenler
        List<Rezervation> GetListWithRezervationByPrevious(int id);//geçmiş  olanlar

    }
}
