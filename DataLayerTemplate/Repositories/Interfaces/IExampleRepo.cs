using DataLayerTemplate.Entities;
using DataLayerTemplate.Repositories.Base;

namespace DataLayerTemplate.Repositories.Interfaces
{
    /// <summary>
    /// For most repositories they will be empty since the RepoBase takes
    /// care of CRUD functionality, only if you need a custom call do you 
    /// need to add it here
    /// </summary>
    public interface IExampleRepo : IRepo<ExampleEntity>
    {
        // Here's an example of a custom call that is not covered by CRUD
        ExampleEntity FindByFirstName(string firstName);
    }
}
