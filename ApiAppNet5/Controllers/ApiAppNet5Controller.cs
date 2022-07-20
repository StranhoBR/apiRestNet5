using AutoMapper;
using ApiAppNet5.Data;
using ApiAppNet5.Data;
using ApiAppNet5.Data.Dtos;
using ApiAppNet5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAppNet5API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiAppNet5Controller : ControllerBase
    {
        private ApiAppNet5Context _context;
        private IMapper _mapper;

        public ApiAppNet5Controller(ApiAppNet5Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpPost]
        public IActionResult AdicionaApiAppNet5([FromBody] CreateApiAppNet5Dto apiappDto)
        {
            ApiApp apiapp = _mapper.Map<ApiApp>(apiappDto);
            _context.ApiApp.Add(apiapp);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaApiAppNet5PorId), new { Id = apiapp.Id }, apiapp);
        }

        [HttpGet]
        public IEnumerable<ApiApp> RecuperaApiAppNet5()
        {
            return _context.ApiApp;
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaApiAppNet5PorId(int id)
        {
            ApiApp apiapp = _context.ApiApp.FirstOrDefault(apiapp => apiapp.Id == id);
            if (apiapp != null)
            {
                ReadApiAppNet5Dto apiappDto = _mapper.Map<ReadApiAppNet5Dto>(apiapp);

                return Ok(apiappDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaApiAppNet5(int id, [FromBody] UpdateApiAppNet5Dto ApiAppNet5Dto)
        {
            ApiApp apiapp = _context.ApiApp.FirstOrDefault(apiapp => apiapp.Id == id);
            if (apiapp == null)
            {
                return NotFound();
            }
            _mapper.Map(apiappDto, apiapp);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaApiAppNet5(int id)
        {
            ApiApp apiapp = _context.ApiApp.FirstOrDefault(apiapp => apiapp.Id == id);
            if (apiapp == null)
            {
                return NotFound();
            }
            _context.Remove(apiapp);
            _context.SaveChanges();
            return NoContent();
        }

    }
}
