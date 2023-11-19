namespace WebApplication1.Controllers
{
    public class JobC
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
        public int HoursInDay { get; set; }

        public JobC(int id, string name, string profession, int hoursInDay)
        {
            Id = id;
            Name = name;
            Profession = profession;
            HoursInDay = hoursInDay;
        }
    }
}
