﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    interface IEnemy<T>
    {
        void Damage(T t);
    }
}
