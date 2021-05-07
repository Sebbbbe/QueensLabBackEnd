using System;
using System.Collections.Generic;

namespace EvaluationAssignmentQueensLab.Models
{
    public class Section
    {
        public Guid SectionID { get; set; }

        public int? VisitorAmount { get; set; }
        public string SectionName { get; set; }

        public List<Visitor> Visitors { get; set; }

        public Guid? ShopID { get; set; }

        public Shop Shop { get; set; }



    }
}
