using System.Linq;


//creating this because it allows a collection of objects to be queried efficiently. Using this
//will allow me to ask the database fo just the objects from a database that i require using
//standard LINQ statements and without needing to know what database server stores the datat or
//how it processes the query

//will allow the caller to obtain a sequences of project objects
//chapter 8 page 201
namespace BuffteksWebsite.Models 
{  
    public interface IProjectRepository 
    {
        IQueryable<Project> Projects {get;}
    }
        
    
}