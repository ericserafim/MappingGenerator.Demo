using MappingGenerator.Demo.Dtos;
using MappingGenerator.Demo.Models;
using System.Linq;

namespace MappingGenerator.Demo.Mappers
{
    public static class UserMapper
    {
        public static UserDto Map(User user)
        {
            return new UserDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Addresses = user.Addresses?.ConvertAll(userAddress => new AddressDto
                {
                    Street = userAddress.Street,
                    Number = userAddress.Number,
                    City = new CityDto
                    {
                        Name = userAddress.City.Name
                    },
                    Country = new CountryDto
                    {
                        Name = userAddress.Country.Name
                    }
                }).AsReadOnly()
            };
        }

        public static User Map(UserDto userDto)
        {
            return new User
            {
                Id = userDto.Id,
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                Addresses = userDto.Addresses?.Select(userDtoAddress => new Address
                {
                    Street = userDtoAddress.Street,
                    Number = userDtoAddress.Number,
                    City = new City
                    {
                        Name = userDtoAddress.City.Name
                    },
                    Country = new Country
                    {
                        Name = userDtoAddress.Country.Name
                    }
                }).ToList()
            };
        }

        public static UserDto ToDto(this User user) => Map(user);        

        public static User ToEntity(this UserDto userDto) => Map(userDto);
    }
}
