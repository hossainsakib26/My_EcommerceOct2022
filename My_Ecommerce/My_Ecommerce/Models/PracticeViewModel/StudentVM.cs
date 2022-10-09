using System.ComponentModel.DataAnnotations;

namespace My_Ecommerce.Models.PracticeViewModel
{
    public class StudentVM
    {
        public long ID { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        public DateOnly? Birthday { get; set; }
        public int? Gender { get; set; }

        //common property
        public long? UserID { get; set; }
        public DateTime? DataAddedOn { get; set; }
        public bool? IsDelete { get; set; }
    }
}
