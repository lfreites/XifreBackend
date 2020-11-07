using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using DomainModels;
using Microsoft.AspNetCore.Mvc;


namespace XifreBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController : Controller
    {
        private readonly ITeacherService _teacherService;
        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet("{name}")]
        public Teacher Get(string name)
        {
            //var teacherService = new TeacherService();
    
            return _teacherService.Find(name);
        }
    }
}
