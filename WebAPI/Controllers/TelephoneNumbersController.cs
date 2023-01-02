using Business.Abstract;
using Entities.Dtos.TelephoneNumber;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TelephoneNumbersController : ControllerBase
    {
        private readonly ITelephoneNumberService _telephoneNumberService;
        public TelephoneNumbersController(ITelephoneNumberService telephoneNumberService)
        {
            _telephoneNumberService = telephoneNumberService;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _telephoneNumberService.GetAllAsync();
            if (response.IsSuccessful) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpGet("get-by-id")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _telephoneNumberService.GetByIdAsync(id);
            if (response.IsSuccessful) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpGet("get-by-customerId")]
        public async Task<IActionResult> GetByCustomerId(int customerId)
        {
            var response = await _telephoneNumberService.GetByCustomerIdAsync(customerId);
            if (response.IsSuccessful) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(CreateTelephoneNumberDto createTelephoneNumberDto)
        {
            var response = await _telephoneNumberService.AddAsync(createTelephoneNumberDto);
            if (response.IsSuccessful) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(UpdateTelephoneNumberDto updateTelephoneNumberDto)
        {
            var response = await _telephoneNumberService.UpdateAsync(updateTelephoneNumberDto);
            if (response.IsSuccessful) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _telephoneNumberService.DeleteByIdAsync(id);
            if (response.IsSuccessful) return Ok(response);
            return BadRequest(response.Message);
        }
    }
}