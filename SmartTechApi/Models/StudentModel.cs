using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SmartTechApi.Models
{
    [JsonObject("student")]
    public class StudentModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        [Required]
        public string Name { get; set; }

        [JsonProperty("birthDate")]
        [Required]
        public DateTime BirthDate { get; set; }

        [JsonProperty("imageName")]
        public string ImageName { get; set; }

        [JsonProperty("address")]
        [Required]
        public string Address { get; set; }

        [JsonProperty("phone")]
        [Required]
        public string Phone { get; set; }

        [JsonProperty("facultyId")]
        [Required]
        public int FacultyId { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("facultyName")]
        public string FacultyName { get; set; }
    }
}