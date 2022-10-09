using System.ComponentModel.DataAnnotations;

namespace My_Ecommerce.Models.PracticeModel
{
    public class Student
    {
        [Key]
        public long ID { get; set; }
        public String Name { get; set; }
        public string Address { get; set; }
        public DateOnly? Birthday { get; set; }
        public int? Gender { get; set; }

        //common property
        public long? UserID { get; set; }
        public DateTime? DataAddedOn { get; set; }
        public bool? IsDelete { get; set; }

    }
}
