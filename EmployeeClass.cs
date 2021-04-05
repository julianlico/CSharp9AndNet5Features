namespace Net5FeaturesTest
{
    public class EmployeeClass
    {
        public EmployeeClass(int id)
        {
            Id = id;
        }
        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
