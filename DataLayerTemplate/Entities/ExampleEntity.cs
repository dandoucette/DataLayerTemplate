using DataLayerTemplate.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayerTemplate.Entities
{
    /// <summary>
    /// You can delete this class after using the template, it's just a placeholder.
    /// Make sure your entities inherit from entity base.  All entities will have a surrogate
    /// key called Id.  This will signal EntityFramework to use this as a primary key and
    /// give it the identity seed property
    /// </summary>
    public class ExampleEntity : EntityBase
    {
        // Just some example properties

        // if you don't specify a max length EF will set your string fields to varchar(max)
        // which isn't terrible but it's not what you normally want
        [MaxLength(50)]
        public string FirstName { get; set; }
        
        // Just because your data type is not nullable won't make EF do the same. See the 
        // MyDatabaseContext for examples on making fields required.
        public DateTime StartDate { get; set; }
        public int EmployeeNumber { get; set; }
        
        // making your data type nullable will signal EF that the field can contain nulls
        public DateTime? EndDate { get; set; }

    }
}
