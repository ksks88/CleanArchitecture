using System.Collections.Generic;
using CleanArchitecture.Entities;

namespace CleanArchitecture.UseCases.Contracts
{
    public interface ICourseRepository
    {
        Course GetByCode(string code);
        IList<Course> GetAll();
    }
}
