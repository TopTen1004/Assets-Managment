﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Data.Entities
{
    [Table("Assets")]
    public class AssetEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? TankName { get; set; }
        public float Amount { get; set; }

        public float Latitude { get; set; }

        public float Longitude { get; set; }

        public float Capacity { get; set; }

        public string? UserEmail { get; set; }
        public int OwnerId { get; set; }

    }
}
