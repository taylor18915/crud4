using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace crud4.Data
{
    public class employees
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EID { get; set; }
        public  string FName { get; set; }
        public string Lname { get; set; }


        [ForeignKey("DID")]
        public departments DeptId { get; set; }
    }
}
