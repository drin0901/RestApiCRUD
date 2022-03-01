﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiCRUD.Models
{
    public class PersonalInfo
    {
        [Key]
        public int? Id { get; set; }
        [MaxLength(200)]
        [Required]
        public string FirstName { get; set; }
        [MaxLength(200)]
        [Required]
        public string LastName { get; set; }
        [Required]
        public long? PhoneNumber { get; set; }
        [MaxLength(200)]
        [Required]
        public string EmailAddress { get; set; }
        [MaxLength(200)]
        public string Address { get; set; }
        [MaxLength(200)]
        public string Notes { get; set; }
        public DateTime? BirthDay { get; set; }
        public bool IsActive { get; set; } = true;

    }
}
