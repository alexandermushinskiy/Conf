using System;
using System.ComponentModel.DataAnnotations;

namespace Conf.Management.WebApi.Models.Requests
{
    public class CreateRequestModel
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string OwnerName { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string OwnerEmail { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Venue { get; set; }
    }
}
