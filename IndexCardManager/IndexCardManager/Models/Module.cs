using System;
using System.Collections.Generic;
using System.Text;

namespace IndexCardManager.Models
{
    public class Module
    {
        public string Name { get; set; }
        public List<IndexCard> IndexCards { get; set; }
    }
}
