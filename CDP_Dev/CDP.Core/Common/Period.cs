using System;
using System.Collections.Generic;
using System.Text;

namespace CDP.Core.Common
{
    public class Period
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Value { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}
