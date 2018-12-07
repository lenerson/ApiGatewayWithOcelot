using System;

namespace Catalog.Domain.Models
{
    public class Customer
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }

        protected Customer() { }

        public static Customer CreateNew(string name) =>
            new Customer
            {
                Id = Guid.NewGuid(),
                Name = name
            };
    }
}
