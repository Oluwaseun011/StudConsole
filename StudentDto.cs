using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studConsole
{
    public class StudentDto
    {
        public string Id{get;set;} 
        public string FirstName{get; set;} 
        public string Email{get; set;}
        public string MatricNumber{get;set;}
        public bool IsDeleted{get; set;}
    }

    public class RegisterStudentRequestModel
    {
        public string FirstName{get; set;} 
        public string Email{get; set;}
    }

    public class UpdateStudentRequestModel
    {
        public string FirstName{get; set;} 
    }

    public class BaseResponse
    {
        public string Message{get; set;}
        public bool Status{get; set;}
        public List<StudentDto> Data{get; set;}
    }
}