using System;
using System.Collections.Generic;

namespace EvaluationAssignmentQueensLab.Models
{
    public class EnterExit
    {

        public Guid EnterExitID { get; set; }
        public Guid VisitorID { get; set; }

        public string Status { get; set; }

        public DateTime Time { get; set; }





        public List<Visitor> Visitors { get; set; }
    }


}

