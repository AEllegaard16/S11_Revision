using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PresseMots.Models
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual IList<StoryTag> StoryTags { get; set; }
    }
}
