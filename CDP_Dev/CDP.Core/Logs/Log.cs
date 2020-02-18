using System;
using System.Collections.Generic;
using System.Text;

namespace CDP.Core.Logs
{
    public class Log
    {
        public int Id { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
