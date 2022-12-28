using Business.Abstract;
using Entities.Dtos.Address;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly IAddressService _addressService;
        public AddressesController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _addressService.GetAllAsync();
            if (response.IsSuccessful) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpGet("get-by-id")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _addressService.GetByIdAsync(id);
            if (response.IsSuccessful) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(CreateAddressDto createAddressDto)
        {
            var response = await _addressService.AddAsync(createAddressDto);
            if (response.IsSuccessful) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(UpdateAddressDto updateAddressDto)
        {
            var response = await _addressService.UpdateAsync(updateAddressDto);
            if (response.IsSuccessful) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(AddressDto addressDto)
        {
            var response = await _addressService.DeleteAsync(addressDto);
            if (response.IsSuccessful) return Ok(response);
            return BadRequest(response.Message);
        }
    }
}