﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChatAppProject.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string User { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string RecepientUserId { get; set; }
        [Required]
        public string SenderUserId { get; set; }
        
        [ForeignKey("SenderUserId")]
        public virtual IdentityUser ParrentSenderUserId { get; set; }
    }
}
