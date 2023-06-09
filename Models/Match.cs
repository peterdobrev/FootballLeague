﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FootballLeague.Models
{
    public partial class Match
    {
        public Match()
        {
            Goals = new HashSet<Goal>();
        }

        [Key]
        public int match_id { get; set; }
        [Column(TypeName = "date")]
        public DateTime date { get; set; }
        public int team_1 { get; set; }
        public int team_2 { get; set; }
        public int main_referee { get; set; }
        public int goals_team_1 { get; set; }
        public int goals_team_2 { get; set; }

        [ForeignKey("main_referee")]
        [InverseProperty("Matches")]
        public virtual Referee main_refereeNavigation { get; set; }
        [ForeignKey("team_1")]
        [InverseProperty("Matchteam_1Navigations")]
        public virtual Team team_1Navigation { get; set; }
        [ForeignKey("team_2")]
        [InverseProperty("Matchteam_2Navigations")]
        public virtual Team team_2Navigation { get; set; }
        [InverseProperty("match")]
        public virtual ICollection<Goal> Goals { get; set; }
    }
}