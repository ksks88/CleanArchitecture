using System;
using System.Linq;
using System.Collections.Generic;
using CleanArchitecture.UseCases.Contracts;
using CleanArchitecture.Entities;

namespace CleanArchitecture.ConsoleApp.Gateways
{
    public class CourseRepository : ICourseRepository
    {
        private readonly Dictionary<string, Course> _store = new Dictionary<string, Course>
        {
            { "BIO150", new Course {
                    Code = "BIO150",
                    Description = "Biology 150",
                    StartDate = DateTime.UtcNow.AddMonths(2),
                    EndDate = DateTime.UtcNow.AddMonths(6)
                }
            },
             { "HIS200", new Course {
                    Code = "HIS200",
                    Description = "History 200",
                    StartDate = DateTime.UtcNow.AddMonths(2),
                    EndDate = DateTime.UtcNow.AddMonths(6)
                }
            },
             { "MAT100", new Course {
                    Code = "MAT100",
                    Description = "Math 100",
                    StartDate = DateTime.UtcNow.AddMonths(2),
                    EndDate = DateTime.UtcNow.AddMonths(6)
                }
            }
        };

        public Course GetByCode(string code)
        {
            return _store[code];
        }

        public IList<Course> GetAll()
        {
            return _store.Values.ToList();
        }
    }
}
