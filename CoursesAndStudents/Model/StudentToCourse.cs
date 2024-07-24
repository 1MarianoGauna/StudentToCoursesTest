namespace CoursesAndStudents.Model
{
    public class StudentToCourse
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public decimal Amount { get; set; }

        public DateTime StartDate {get;set;}
        public DateTime EndDate {get;set;}
        public string creditCardNumber { get; set; }
        public string cardHolderName { get; set; }
        public string expirationDate { get; set; }
        public string cvv { get; set; }
    }
}
