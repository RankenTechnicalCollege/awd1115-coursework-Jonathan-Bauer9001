namespace FAQs1.Models
{
    public class FAQ
    {   
        public int FAQId { get; set; } // Primary key
        public string Question { get; set; } = string.Empty;
        public string Answer { get; set; } = string.Empty;
        public string CategoryId { get; set; } = string.Empty; // Foreign key to Category
        public Category Category { get; set; } = null!; // Navigation property
        public string TopicId { get; set; } = string.Empty; // Foreign key to Topic
        public Topic Topic { get; set; } = null!; // Navigation property

    }
}
