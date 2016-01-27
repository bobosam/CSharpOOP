﻿using SampleExamEmpires.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExamEmpires.Contracts
{
    public interface IResource
    {
        ResourceType ResourceType { get; }

        int Quantity { get; }
    }
}
