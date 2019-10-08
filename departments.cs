using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace crud4.Data
{
    public class departments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DID { get; set; }
        [Display(Name ="department Id")]
        public string Dname { get; set; }
        [Display(Name ="Dept Head")]
        public string DHead { get; set; }
    }
}
