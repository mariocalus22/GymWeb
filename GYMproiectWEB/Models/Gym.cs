using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GYMproiectWEB.Models
{
    public class Gym
    {
        public int ID { get; set; }
        [Display(Name = "Customer")]
        public string Name { get; set; }
        public string Coach { get; set; }

        public int Age { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartingDate { get; set; }
    }
}
