using System;

namespace EvaluationAssignmentQueensLab.Models
{
    public class Visitor
    {
        public Guid VisitorID { get; set; }
        public string VisitorName { get; set; }

        public Guid? SectionID { get; set; }

        public DateTime VisitorEntered { get; set; }
        public Guid? ShopID { get; set; }

        public Shop Shop { get; set; }

        public Section Section { get; set; }

        public EnterExit EnterExit { get; set; }


    }
}
