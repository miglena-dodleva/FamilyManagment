﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyManagement.Services.Models.FamilyManagement
{
    public class UserToFamilyModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "User ID is required")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Family ID is required")]
        public int FamilyId { get; set; }
    }
}
