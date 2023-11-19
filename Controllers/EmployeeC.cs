namespace WebApplication1.Controllers
{
    public class EmployeeC
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Experience { get; set; }
        public string Profession { get; set; }

        public EmployeeC(int id, string name, bool experience, string profession)
        {
            Id = id;
            Name = name;
            Experience = experience;
            Profession = profession;
        }
    }
}
