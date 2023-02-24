﻿using System;
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
        public int Id { get; set; }

        public float Oil { get; set; }

        public float Latitude { get; set; }

        public float Longitude { get; set; }

        public string? Manager { get; set; }

        public string? UserEmail { get; set; }

    }
}
