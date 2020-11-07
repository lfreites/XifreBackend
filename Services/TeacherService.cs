using Contracts;
using DomainModels;
using System;

namespace Services
{
    public class TeacherService : ITeacherService
    {
        public Teacher Find(string name)
        {
            var result = new Teacher
            {
                Name = name,
                SurName = "Xifre"
            };
            return result;
        }
    }
}
