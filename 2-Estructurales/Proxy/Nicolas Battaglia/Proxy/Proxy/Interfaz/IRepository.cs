﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    interface IRepository
    {
         IList<Customer> GetAll();
         void Save(Customer customer);
    }
}
