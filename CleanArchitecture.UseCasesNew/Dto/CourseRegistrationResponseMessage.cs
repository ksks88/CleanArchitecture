using System.Collections.Generic;
using CleanArchitecture.UseCases.Contracts;

namespace CleanArchitecture.UseCases.Dto
{
    public class CourseRegistrationResponseMessage : ResponseMessage
    {
        public List<string> Errors { get; private set; }
        public CourseRegistrationResponseMessage(bool success,List<string> errors, string message = null) : base(success, message)
        {
            Errors = errors;
        }
    }
}
