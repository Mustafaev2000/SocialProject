﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SocialProject.WebUI.Entities
{
    public class Message
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Text { get; set; }
        public DateTime When { get; set; }

        public string UserId { get; set; }
        public virtual CustomIdentityUser CustomIdentityUser { get; set; }
    }
}
