using System;
using System.Collections.Generic;
using System.Text;

namespace MappingGenerator.Demo.Models
{
    public class User
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => $"{FirstName}, {LastName}";

        public List<Address> Addresses { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append($"{Id} - {FullName}{Environment.NewLine}");

            builder.Append($"Address:{Environment.NewLine}");
            foreach (var address in Addresses)
            {
                builder.Append($"   => {address}{Environment.NewLine}");
            }

            return builder.ToString();
        }
    }
}
