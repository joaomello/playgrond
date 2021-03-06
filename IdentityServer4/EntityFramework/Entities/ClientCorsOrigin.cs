﻿using System.ComponentModel.DataAnnotations;

namespace IdentityServer.EntityFramework.Entities
{
    public class ClientCorsOrigin
    {
        [Key]
        public virtual int Id { get; set; }

        [Required]
        [StringLength(150)]
        public virtual string Origin { get; set; }

        public virtual Client Client { get; set; }
    }
}
