using Business.Abstract;
using Entities.Dtos.Customer;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        #region GetActions
        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _customerService.GetAllAsync();
            if (response.IsSuccessful) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpGet("get-by-id")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _customerService.GetByIdAsync(id);
            if (response.IsSuccessful) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpGet("get-customers-details")]
        public async Task<IActionResult> GetCustomersDetails()
        {
            var response = await _customerService.GetCustomersDetailsAsync();
            if (response.IsSuccessful) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpGet("get-customer-details-by-id")]
        public async Task<IActionResult> GetCustomerDetailsById(int id)
        {
            var response = await _customerService.GetCustomerDetailsByIdAsync(id);
            if (response.IsSuccessful) return Ok(response);
            return BadRequest(response.Message);
        }
        #endregion


        [HttpPost("create")]
        public async Task<IActionResult> Create(CreateCustomerDto createCustomerDto)
        {
            var response = await _customerService.AddAsync(createCustomerDto);
            if (response.IsSuccessful) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(UpdateCustomerDto updateCustomerDto)
        {
            var response = await _customerService.UpdateAsync(updateCustomerDto);
            if (response.IsSuccessful) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(CustomerDto customerDto)
        {
            var response = await _customerService.DeleteAsync(customerDto);
            if (response.IsSuccessful) return Ok(response);
            return BadRequest(response.Message);
        }
    }
}