namespace SampleExamEmpires.Core.Factories
{
    using Contracts;
    using Enum;
    using Models;
    public class ResourceFactory : IResourceFactory
    {
        public IResource CreateResource(ResourceType resourceType, int quantity)
        {
            var resource = new Resource(quantity, resourceType);

            return resource;
        }
    }
}
