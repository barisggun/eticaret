﻿using ETicaretApp_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp_BusinessLayer.Abstract
{
    public interface IUserService
    {
        void AddWriter(User user);
    }
}
