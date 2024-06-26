﻿using System.ComponentModel.DataAnnotations;

namespace WebApp.ViewModels.Sections;

public class SubscribeViewModel
{
    [Required]
    [EmailAddress]
    [Display(Name = "Email", Prompt = "Your Email")]
    public string Email { get; set; } = null!;
    public bool DailyNewsletter { get; set; }
    public bool AdvertisingUpdates { get; set; }
    public bool WeekinReview {  get; set; }
    public bool EventUpdates { get; set; }
    public bool StarupsWeekly { get; set; }
    public bool Podcasts { get; set; }
}
