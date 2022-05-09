using System;
using System.Collections.Generic;
using System.Text;

namespace eWireApi.Entities.Models
{
    public class SchemeDetails : ResponseBaseModel
    {
        public string SchCat { get; set; }
        public string SchCode { get; set; }
        public string SchName { get; set; }
    }
}
