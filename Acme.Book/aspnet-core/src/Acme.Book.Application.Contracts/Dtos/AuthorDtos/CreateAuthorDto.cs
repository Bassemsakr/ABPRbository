﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Book.Dtos.AuthorDtos
{
    public class CreateAuthorDto
    {

        [Required]
        [StringLength(AuthorConsts.MaxNameLength)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public DateTime BirthDate { get; set; }

        public string? ShortBio { get; set; }
        public bool IsActive { get; set; } = false;
    }
}
