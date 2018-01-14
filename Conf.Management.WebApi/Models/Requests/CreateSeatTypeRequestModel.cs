using System.ComponentModel.DataAnnotations;

namespace Conf.Management.WebApi.Models.Requests
{
    public class CreateSeatTypeRequestModel
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}