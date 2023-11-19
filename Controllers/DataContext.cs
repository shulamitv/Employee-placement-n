namespace WebApplication1.Controllers
{
    public class DataContext
    {
        public List<CollegeC> collegeList { get; set; }
        public List<EmployeeC> employeeList{ get; set; }
        public List<JobC> jobsList { get; set; }

    
        public DataContext()
        {
            collegeList = new List<CollegeC>()
        {
            new CollegeC(1,"wolf"),
            new CollegeC(2,"cahana"),
        };

         employeeList = new List<EmployeeC>()
        {
            new EmployeeC(1,"rut levi",true,"programing"),
            new EmployeeC(2,"rachel cohen",true,"graphics"),
        };

       jobsList = new List<JobC>()
       {
           new JobC(1,"intel","programing",9),
           new JobC(1,"tax","tax consultancy",7),
           new JobC(1,"big","graphics",8),
           new JobC(1,"abc","architecture",9),
           new JobC(1,"wow","Accounting",9),
       };

    }
    }
}
