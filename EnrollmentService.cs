public class EnrollmentService
{
    public EnrollmentRecord ProcessRegistration(Student? student, Course? course)
    {
         if (student is null)
         throw new ArgumentNullException(nameof(student));
         if (course is null)
         throw new ArgumentNullException(nameof(course));
         if (course.Capacity <= 0)
         throw new InvalidOperationException($"Course {course.Code} has invalid capacity: {course.Capacity}. Capacity must be greater than zero.");
         if (course.EnrolledCount >= course.Capacity)
         throw new CapacityReachedException(course.Code);

         string status = student.GPA switch
        {
            >= 3.5m => "Honors",
            >= 2.5m => "Good Standing",
            >= 2.0m => "Probation",
            _ => "Academic Warning"
        };

        Console.WriteLine($"{student.Name} is in {status}.");
        return new EnrollmentRecord(student.Id, course.Code, DateTime.Now);
    }
}
