using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Model
{
    public class config_major_kindModel
    {
        [Key]
        public int mfk_id { get; set; }  
        public string major_kind_id { get; set; }  
        public string major_kind_name { get; set; } 
    }
}