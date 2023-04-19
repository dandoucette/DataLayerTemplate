using DataLayerTemplate.Entities;
using DataLayerTemplate.Repositories.Base;
using DataLayerTemplate.Repositories.Interfaces;
using System.Linq;

namespace DataLayerTemplate.Repositories
{
    /// <summary>
    /// Example of a entity repository, the idea is each entity should have its
    /// own repository so you can perform CRUD operations on it.  If you need custom
    /// calls or need to override the base you can do so here
    /// </summary>
    public class ExampleRepo : RepoBase<ExampleEntity>, IExampleRepo
    {
        public ExampleRepo(MyDatabaseContext context) : base(context)
        { }

        // We would implement our custom call from our interface here
        // this is just an example, not supposed to be actual functionality
        public ExampleEntity FindByFirstName(string firstName)
        {
            return Context.Examples.Where(e => e.FirstName == firstName).FirstOrDefault();
        }


        // if a base call doesn't do what you need you can override it and change what it does
        public override ExampleEntity Find(int? id)
        {
            return base.Find(id);
        }
    }
}
