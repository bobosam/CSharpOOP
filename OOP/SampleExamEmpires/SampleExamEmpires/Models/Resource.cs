using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExamEmpires.Models
{
    using Contracts;
    using Enum;

    public class Resource : IResource
    {
        public Resource(int quantity, ResourceType resourceType)
        {
            this.Quantity = quantity;
            this.ResourceType = resourceType;
        }
        public int Quantity { get; }     

        public ResourceType ResourceType { get; }
        
    }
}
