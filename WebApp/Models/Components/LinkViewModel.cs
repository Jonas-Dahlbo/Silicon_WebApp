namespace WebApp.Models.Components;

public class LinkViewModel
{
    public string? LinkType { get; set; }
    public string ControllerName { get; set; } = null!;
    public string ActionName { get; set;} = null!;
    public string LinkText { get; set;} = null!;
}
