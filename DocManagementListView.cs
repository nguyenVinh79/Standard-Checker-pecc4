using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardChecker
{
    class DocManagementListView
    {
            public int ID { get; set; }
            public string DocumentTitle { get; set; }
            public string DocumentCode { get; set; }
            public System.DateTime IssueDate { get; set; }
            public Nullable<System.DateTime> ValidDate { get; set; }
            public Nullable<System.DateTime> ExpireDate { get; set; }
            public string Note { get; set; }
            public Nullable<bool> IsAlternativeDoc { get; set; }
            public Nullable<bool> IsInvalid { get; set; }
            public Nullable<int> SourceDoc { get; set; }
            public string SourceDocString { get; set; }
  
    
}
}
