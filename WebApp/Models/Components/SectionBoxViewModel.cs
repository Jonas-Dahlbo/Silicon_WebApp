namespace WebApp.Models.Components;

public class SectionBoxViewModel
{
    public ImageViewModel SectionImage { get; set; } = null!;
    public string? SectionTitle { get; set; }
    public string SectionText { get; set; } = null!;
}
