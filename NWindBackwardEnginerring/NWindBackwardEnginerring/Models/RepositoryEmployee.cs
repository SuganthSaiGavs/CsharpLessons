namespace NWindBackwardEnginerring.Models
{
    public class RepositoryEmployee
    {
      /*  public static List<Employee> AllEmployees() 
        { 
            NorthwindContext context = new NorthwindContext();
            return context.Employees.ToList();  //context.Dbset.ToList();
        }   */    
        
     
            private NorthwindContext _context;
            public RepositoryEmployee(NorthwindContext context)  //Constructor based dependency injection.
            {
                _context = context;
            }

            public List<Employee> AllEmployees()
            {
                return _context.Employees.ToList();
            }
        }
    }

