using System;

namespace Models
{
    public sealed class EntityDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public InnerEntityDto InnerEntity { get; set; }
    }
}