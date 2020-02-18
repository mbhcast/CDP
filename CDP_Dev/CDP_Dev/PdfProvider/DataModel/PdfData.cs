using CDP.Core.Allocations;
using CDP.Core.Aspirations;
using CDP.Core.Internals;
using CDP.Core.Mentors;
using CDP.Core.Training;
using CDP.Core.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CDP_Dev.PdfProvider.DataModel
{
    public class PdfData
    {
        public string DocumentTitle { get; set; }

        public string CreatedBy { get; set; }

        public string Description { get; set; }

        public List<ItemsToDisplay>  DisplayListItems { get; set; }
        public List<UserTraining> Training { get; set; }
        public User User { get; set; }
        public List<UserAspiration> Aspiration { get; set; }
        public List<UserMentor> Mentor { get; set; }
        public List<UserAllocation> Allocation { get; set; }
        public List<UserInternal> IInternal { get; set; }
        public string DocumentName { get; set; }
    }
}
