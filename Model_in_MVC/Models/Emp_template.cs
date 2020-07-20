using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Model_in_MVC.Models
{
    public class Emp_template
    {
        public int id { get; set; }

        [Display(Name= "Please enter your name")]
        public string  Name{ get; set; }  

        public string Email { get; set; }

        public bool IsOnline{ get; set; }

        [Display(Name = "Date Of birth")]
        [DataType(DataType.Date)]            
        public DateTime BirthDate { get; set; }


        [Display(Name = "birth time")]
        [DataType(DataType.Time)]
        public DateTime BirthTime { get; set; }




    }
}