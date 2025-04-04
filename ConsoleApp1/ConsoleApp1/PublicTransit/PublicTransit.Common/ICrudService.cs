﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.PublicTransit.PublicTransit.Common
{
    public interface ICrudService<T>
    {
        void Create(T element);
        T Read(Guid id);
        IEnumerable<T> ReadAll();
        void Update(T element);
        void Remove(T element);
    }

}
