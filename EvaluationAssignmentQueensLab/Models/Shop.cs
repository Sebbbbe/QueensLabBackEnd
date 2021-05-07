using System;
using System.Collections.Generic;

namespace EvaluationAssignmentQueensLab.Models
{
    public class Shop
    {

        public Guid ShopID { get; set; }


        public string ShopName { get; set; }

        public List<Visitor> Visitors { get; set; }

        public List<Section> Sections { get; set; }





    }
}
