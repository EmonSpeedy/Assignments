using StudentManagement.Data;
using StudentManagement.Models;


namespace StudentManagement.Repositories;

public class StudentRepository
{
    private readonly ApplicationDbContext db;

    public StudentRepository(ApplicationDbContext context)
    {
        db = context;
    }

    public List<Student> GetAll()
    {
        return db.Students.ToList();
    }

    public Student GetById(int id)
    {
        return db.Students.FirstOrDefault(x => x.Id == id);
    }

    public void Add(Student s)
    {
        db.Students.Add(s);
        db.SaveChanges();
    }

    public void Update(Student s)
    {
        db.Students.Update(s);
        db.SaveChanges();
    }

    public void Delete(int id)
    {
        var s = db.Students.FirstOrDefault(x => x.Id == id);
        if (s != null)
        {
            db.Students.Remove(s);
            db.SaveChanges();
        }
    }
}
