using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace mvcimg.Models
{
    public class tblregistration
    {
        [Key]
        public int rid { get; set; }
        public string rname { get; set; }
        public string remail { get; set; }
        public string rpassword { get; set; }
        public string rimg { get; set; }
    }
}