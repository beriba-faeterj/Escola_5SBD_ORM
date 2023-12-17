using System.ComponentModel.DataAnnotations;

namespace Escola_5SBD_ORM.Domain.Model._Base
{
    public class BaseModel
    {
        [Key]
        public int id { get; set; }
    }
}
