using WebApp.Models.Components;

namespace WebApp.Models.Sections;

public class NewsletterViewModel
{
    public string Id { get; set; } = null!;
    public string Title { get; set; } = null!;
    public ImageViewModel Image { get; set; } = null!;
    public string FormTitle { get; set; } = null!;
    public List<string> CheckboxText { get; set; } =null!;
    public string Placeholder { get; set; } = null!;
    public LinkViewModel Buttton { get; set; } = null!;
}
