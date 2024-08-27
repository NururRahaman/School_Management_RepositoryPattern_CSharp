using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Domain
{
    [Serializable]
    [Table("Student")]
    public class Student: IEntity<int>
    {
        [Key]
        public int StudentID { get; set; }
        [Required]
        [StringLength(50)]
        public string StudentName { get; set; }
        [Required]
        [StringLength(15)]
        public string ClassName { get; set; }
        [Required]
        [StringLength(10)]
        public int ClassRoll { get; set; }
        [Required]
        [StringLength(15)]
        public string CellPhoneNo { get; set; }

    }
}
