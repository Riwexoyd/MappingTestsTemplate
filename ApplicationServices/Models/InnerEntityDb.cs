using System;

namespace ApplicationServices.Models
{
    internal sealed class InnerEntityDb
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public InnerEntityType InnerEntityType { get; set; }
    }
}
