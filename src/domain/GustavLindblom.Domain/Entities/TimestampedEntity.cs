using System;
using System.Collections.Generic;
using System.Text;

namespace GustavLindblom.Domain.Entities
{
    public class TimestampedEntity
    {
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
