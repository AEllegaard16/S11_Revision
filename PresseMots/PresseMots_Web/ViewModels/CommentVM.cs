using System.Collections.Generic;
using PresseMots.Models;

namespace PresseMots.ViewModels
{
    public class CommentVM
    {
        public int WordCount { get; set; }
        public string StoryTitle { get; set; }
        public string ShortStory { get; set; }
        public int? StoryId { get; set; }
        public virtual IEnumerable<Comment> Comments { get; set; }
    }
}
