using System;
using AutoMapper;

namespace AutoMapperSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User()
            {
                EmailAddress = "burak.caglayan@ad.com",
                Id = 1,
                FirstName = "Burak",
                LastName = "Çağlayan"
            };

            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });

            var userDto = Mapper.Map<User, UserViewModel>(user);


            Console.WriteLine(userDto.Id.ToString() + "-" +userDto.EmailAddress);
            Console.ReadLine();
        }
    }
}
