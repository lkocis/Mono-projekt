namespace Introduction.WebAPI
{
    public class Author
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Id { get; set; }
        public DateOnly DOB { get; set; }

        public Author(string firstName, string lastName, int id, DateOnly dob)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            DOB = dob;
        }

        public Author()
        { }
    }
}