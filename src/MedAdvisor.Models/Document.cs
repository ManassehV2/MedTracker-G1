using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedAdvisor.Models
{
  public class Document
    {
        public int DocId { get; set; }

        public string Name { get; set; }
        public string title { get; set; }
        public int UserId { get; set; }
    }
}
