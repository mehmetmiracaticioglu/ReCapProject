﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfCarColorDal : EfEntityRepositoryBase<Color, RecapProjectDBContext>,ICarColorDal
    {
    }
}
