using CleanArchitecture.Entities;

namespace CleanArchitecture.UseCases.Contracts
{
    public interface IStudentRepository
    {
        Student GetById(int id);
        void Save(Student student);
    }
}
