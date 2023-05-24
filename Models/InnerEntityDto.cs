using System;

namespace Models
{
    public sealed class InnerEntityDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public InnerEntityDtoType InnerEntityType { get; set; }
    }
}
