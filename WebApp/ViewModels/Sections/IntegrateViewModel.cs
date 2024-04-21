using WebApp.Models.Components;

namespace WebApp.Models.Sections;

public class IntegrateViewModel
{
    public string Id { get; set; } = null!;
    public SectionTitleViewModel SectionTitle { get; set; } = null!;
    public List<SectionBoxViewModel> SectionBoxes { get; set; } = null!;
}
