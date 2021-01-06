﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace B2CMultiTenant.Models
{
    public class TenantDetails
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Please enter name"), MaxLength(30)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter description"), MaxLength(30)]
        [Display(Name = "Long name")]
        public string LongName { get; set; }
        [Required(ErrorMessage = "Enforce MFA for all users")]
        [Display(Name = "Require MFA?")]
        public bool RequireMFA { get; set; }
        [Display(Name = "AAD directory id of tenant creator")]
        [Editable(false)]
        public string OwnerIssuer { get; set; }
        [Display(Name = "Allow others from same directory to join with no invitation")]
        [Editable(false)]
        public bool AllowNoInviteFromSameIssuer { get; set; }
    }
}
