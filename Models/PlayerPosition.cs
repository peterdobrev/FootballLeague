﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FootballLeague.Models
{
    public partial class PlayerPosition
    {
        public PlayerPosition()
        {
            Players = new HashSet<Player>();
        }

        [Key]
        public int position_id { get; set; }
        [Required]
        [StringLength(20)]
        [Unicode(false)]
        public string position_name { get; set; }

        [InverseProperty("positionNavigation")]
        public virtual ICollection<Player> Players { get; set; }
    }
}