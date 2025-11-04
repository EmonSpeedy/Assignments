using StudentManagement.Models;
using StudentManagement.Repositories;


namespace StudentManagement.Services;

public class StudentService
{
    private readonly StudentRepository repo;

    public StudentService(StudentRepository repository)
    {
        repo = repository;
    }

    public List<Student> GetAllStudents()
    {
        return repo.GetAll();
    }

    public Student GetStudent(int id)
    {
        return repo.GetById(id);
    }

    public void AddStudent(Student s)
    {
        repo.Add(s);
    }

    public void UpdateStudent(Student s)
    {
        repo.Update(s);
    }

    public void DeleteStudent(int id)
    {
        repo.Delete(id);
    }
}
