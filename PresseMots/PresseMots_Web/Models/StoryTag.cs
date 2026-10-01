using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PresseMots.Models
{
    public class StoryTag
    {
        [Key]
        public int Id { get; set; }
        public int TagId { get; set; }
        public virtual Tag Tag { get; set; }
        public int StoryId { get; set; }
        public virtual Story Story { get; set; }
    }
}
