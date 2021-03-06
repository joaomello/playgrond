﻿using System.ComponentModel.DataAnnotations;

namespace IdentityServer.EntityFramework.Entities
{
    public class ClientClaim
    {
        [Key]
        public virtual int Id { get; set; }

        [Required]
        [StringLength(250)]
        public virtual string Type { get; set; }

        [Required]
        [StringLength(250)]
        public virtual string Value { get; set; }

        public virtual Client Client { get; set; }
    }
}
