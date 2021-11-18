

namespace EspacioNube.web.Models
{
    public class EntityBase
    {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long ID { get; set; }
    }
}

