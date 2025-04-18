﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
  public  interface IGenericDal<T>
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> Getlist();
        T GetByID(int id);

        List<T> GetListByFilter(Expression<Func<T, bool>> filter);//şarta göre listele (filtrele) <T, bool> burda entity yazılır(T) sonra cıktı true mu false sonucu verecek
    }
}
