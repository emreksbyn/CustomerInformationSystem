using AutoMapper;
using Business.Abstract;
using Core.Responses;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos.Customer;

namespace Business.Concrete
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<IResponse<List<CustomerDto>>> GetAllAsync()
        {
            List<Customer> customers = await _customerRepository.GetAllAsync();
            List<CustomerDto> customerDtos = _mapper.Map<List<CustomerDto>>(customers);
            return Response<List<CustomerDto>>.Success(customerDtos, "Müşteriler listelendi.");
        }

        public async Task<IResponse<CustomerDto>> GetByIdAsync(int id)
        {
            Customer customer = await _customerRepository.GetAsync(x => x.Id == id);
            CustomerDto customerDto = _mapper.Map<CustomerDto>(customer);
            return Response<CustomerDto>.Success(customerDto, "Müşteriler listelendi.");
        }

        public async Task<IResponse<NoContent>> AddAsync(CreateCustomerDto createCustomerDto)
        {
            Customer customer = _mapper.Map<Customer>(createCustomerDto);
            await _customerRepository.AddAsync(customer);
            return Response<NoContent>.Success("Müşteri başarı ile eklendi.");
        }

        public async Task<IResponse<NoContent>> UpdateAsync(UpdateCustomerDto updateCustomerDto)
        {
            Customer customer = _mapper.Map<Customer>(updateCustomerDto);
            await _customerRepository.UpdateAsync(customer);
            return Response<NoContent>.Success("Müşteri başarı ile güncellendi.");
        }

        public async Task<IResponse<NoContent>> DeleteAsync(CustomerDto customerDto)
        {
            Customer customer = _mapper.Map<Customer>(customerDto);
            await _customerRepository.DeleteAsync(customer);
            return Response<NoContent>.Success("Müşteri başarı ile silindi.");
        }
    }
}