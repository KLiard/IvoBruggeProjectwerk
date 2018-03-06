using System.Collections.Generic;
using CourseScheduler.AutoMapper.Factories;
using CourseScheduler.Core.Services.Contracts;
using CourseScheduler.Domain.Models;
using CourseScheduler.Dto.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseScheduler.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Module")]
    public class ModuleController : Controller
    {
        private readonly IModuleService _moduleService;

        public ModuleController(IModuleService moduleService)
        {
            _moduleService = moduleService;
        }

        // GET: api/Module
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Module/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Module
        [HttpPost]
        public void Create([FromBody]ModuleDto moduleDto)
        {
            var module = AutoMapperFactory.Map<Module>(moduleDto);

            _moduleService.CreateModule(module);
            _moduleService.SaveModule();
        }
        
        // PUT: api/Module/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
