using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MyCrudApi.Models
{
    public class BaseModel
    {
        public int Id { get; set; }

    }
}
