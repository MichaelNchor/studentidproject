namespace studentcard.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> getStudents();
    }
}
