using WebApp.Models.Components;

namespace WebApp.Models.Sections;

public class FeaturesViewModel
{
    public string Id { get; set; } = null!;
    public SectionTitleViewModel SectionTitle { get; set; } = null!;
    public List<SectionBoxViewModel> SectionBox { get; set; } = null!;
}
