using WebApp.Models.Components;

namespace WebApp.Models.Sections;

public class DownloadAppViewModel
{
    public string Id { get; set; } = null!;
    public ImageViewModel DownloadAppImage { get; set; } = null!;
    public string Title { get; set; } = null!;
    public ImageViewModel StarsImage { get; set; } = null!;
    public List<SectionBoxViewModel> StoreBox {  get; set; } = null!; 
}
