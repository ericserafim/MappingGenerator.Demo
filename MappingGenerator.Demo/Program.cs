using AutoFixture;
using MappingGenerator.Demo.Mappers;
using MappingGenerator.Demo.Models;
using System;

namespace MappingGenerator.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new Fixture().Create<User>();
            var userDto = UserMapper.Map(user);     
            var newUser = UserMapper.Map(userDto);

            Console.WriteLine("UserDto");
            Console.WriteLine(userDto.ToEntity());
            Console.WriteLine("newUser");
            Console.WriteLine(newUser.ToDto());            
        }
    }
}
