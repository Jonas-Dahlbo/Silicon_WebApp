using WebApp.Models.Components;

namespace WebApp.Models.Sections;

public class TaskmanagerViewModel
{
    public string Id { get; set; } = null!;
    public ImageViewModel TaskmangerImage { get; set; } = null!;
    public string Title { get; set; } = null!;
    public List<string> Text { get; set; } = null!;
    public LinkViewModel Link { get; set; } = null!;
}
