using System;

namespace ApplicationServices.Models
{
    internal sealed class EntityDb
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public InnerEntityDb InnerEntity { get; set; }
    }
}
