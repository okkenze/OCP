﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.interfaces
{
    public interface ISaleTotalAmount
    {
        decimal CalculateTotalAmount(decimal SubTotal);
    }
}
