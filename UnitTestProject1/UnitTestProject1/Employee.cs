namespace UnitTestProject1
{
    public class Employee
    {
        public Employee(int id, string name, int baseSalary)
        {
            this.Id = id;
            this.Name = name;
            this.BaseSalary = baseSalary;

        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int BaseSalary { get; set; }
    }
}