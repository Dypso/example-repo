using System;
using System.Collections.Generic;

namespace ZeroAllocationWebIPI.Models
{
    public class ComplexObject
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<string> Tags { get; set; }
        public Dictionary<string, Object> Metadata = new Dictionary<string, Object>();
    }
}