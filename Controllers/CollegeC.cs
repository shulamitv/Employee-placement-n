namespace WebApplication1.Controllers
{
    public class CollegeC
    {

        public int Id { get; set; }
        public string Name { get; set; }
        //public List<Employee> Students { get; set; }

        public CollegeC(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
