using System.ComponentModel.DataAnnotations;

namespace Social_Network.Models
{
    public class Image
    {
        public int ID { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        public string ImageURL { get; set; }

        [Required]
        [MaxLength(4)]
        public string FileExtension { get; set; }

        public int UserID { get; set; }

        public virtual UserProfile User { get; set; }
    }
}
