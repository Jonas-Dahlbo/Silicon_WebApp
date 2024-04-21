using WebApp.Models.Sections;

namespace WebApp.Models.Views;

public class HomeIndexViewModel
{
    public string Title { get; set; } = "Ultimate Task Manager";
    public ShowcaseViewModel Showcase { get; set; } = new ShowcaseViewModel
    {
        Id = "showcase",
        ShowcaseImage = new() { ImageUrl = "images/background-showcase.svg", ImageAlt = "Task Management assistant" },
        Title = "Task Management Assistant You Gonna Love",
        Text = "We offer you a new generation of task management system. Plan, manage & track all your tasks in one flexible tool.",
        Link = new() { LinkType = "theme-s-btn", ActionName = "Index", ControllerName = "Download", LinkText = "Get started for free" },
        BrandsText = "Largest companies use our tool to work efficiently",
        BrandsImages = [
            new() { ImageUrl = "images/brands/brand1.svg"},
            new() { ImageUrl = "images/brands/brand2.svg"},
            new() { ImageUrl = "images/brands/brand3.svg"},
            new() { ImageUrl = "images/brands/brand4.svg"}
            ]
    };

    public FeaturesViewModel Features { get; set; } = new FeaturesViewModel
    {
        Id = "features",
        SectionTitle = new() { Title = "What Do You Get with Our Tool?", Text = "Make sure all your tasks are organized so you can set the priorities and focus on important." },
        SectionBox = [
            new() { SectionImage = new() { ImageUrl = "images/icons/tool-icon1.svg", ImageAlt = "" } , SectionTitle = "Comments on Tasks", SectionText = "Id mollis consectetur congue egestas egestas suspendisse blandit justo." },
            new() { SectionImage = new() { ImageUrl = "images/icons/tool-icon2.svg", ImageAlt = "" }, SectionTitle = "Tasks Analytics", SectionText = "Non imperdiet facilisis nulla tellus Morbi scelerisque eget adipiscing vulputate." },
            new() { SectionImage = new() { ImageUrl = "images/icons/tool-icon3.svg", ImageAlt = "" }, SectionTitle = "Multiple Assignees", SectionText = "A elementum, imperdiet enim, pretium etiam facilisi in aenean quam mauris." },
            new() { SectionImage = new() { ImageUrl = "images/icons/tool-icon4.svg", ImageAlt = "" }, SectionTitle = "Notifications", SectionText = "Diam, suspendisse velit cras ac. Lobortis diam volutpat, eget pellentesque viverra." },
            new() { SectionImage = new() { ImageUrl = "images/icons/tool-icon5.svg", ImageAlt = "" }, SectionTitle = "Sections & Subtasks", SectionText = "Mi feugiat hac id in. Sit elit placerat lacus nibh lorem ridiculus lectus." },
            new() { SectionImage = new() { ImageUrl = "images/icons/tool-icon6.svg", ImageAlt = "" }, SectionTitle = "Data Security", SectionText = "Aliquam malesuada neque eget elit nulla vestibulum nunc cras." },
            ]
    };

    public TaskmanagerViewModel Taskmanager { get; set; } = new TaskmanagerViewModel
    {
        Id = "Taskmanager",
        TaskmangerImage = new() { ImageUrl = "images/task-manager.svg", ImageAlt = "Task Manager" },
        Title = "Manage Your Work",
        Text = [
            "Powerful project management",
            "Transparent work management",
            "Manage work & focus on the most important tasks",
            "Track your progress with interactive charts",
            "Easiest way to track time spent on tasks",
            ],
        Link = new() { LinkType = "theme-btn", LinkText = "Learn more", ControllerName = "", ActionName = "" }
    };

    public DownloadAppViewModel DownloadApp { get; set; } = new DownloadAppViewModel
    {
        Id = "DownloadApp",
        DownloadAppImage = new() { ImageUrl = "images/screens.svg ", ImageAlt = "Task Manager app open in a smartphone" },
        Title = "Download Our App for Any Devices:",
        StarsImage = new() { ImageUrl = "images/icons/rating.svg", ImageAlt = "five stars" },
        StoreBox = [
            new() { SectionImage = new() { ImageUrl = "images/download/appstore.svg", ImageAlt = "Download on the App Store" }, SectionTitle = "Editor's Choice", SectionText = "rating 4.7, 187K+ reviews"},
            new() { SectionImage = new() { ImageUrl = "images/download/googleplay.svg", ImageAlt = "Get it on Google Play" }, SectionTitle = "App of the Day", SectionText = "rating 4.8, 30K+ reviews"},
            ]
    };

    public IntegrateViewModel Integrate { get; set; } = new IntegrateViewModel
    {
        Id = "Integrate",
        SectionTitle = new() { Title = "Integrate Top Work Tools", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin volutpat mollis egestas. Nam luctus facilisis ultrices. Pellentesque volutpat ligula est. Mattis fermentum, at nec lacus." },
        SectionBoxes = [
            new() {SectionImage = new() { ImageUrl = "images/tools/google.svg", ImageAlt = "Google" }, SectionText = "Lorem magnis pretium sed curabitur nunc facilisi nunc cursus sagittis." },
            new() {SectionImage = new() { ImageUrl = "images/tools/zoom.svg", ImageAlt = "Zoom" }, SectionText = "In eget a mauris quis. Tortor dui tempus quis integer est sit natoque placerat dolor." },
            new() {SectionImage = new() { ImageUrl = "images/tools/slack.svg", ImageAlt = "Slack" }, SectionText = "Id mollis consectetur congue egestas egestas suspendisse blandit justo." },
            new() {SectionImage = new() { ImageUrl = "images/tools/gmail.svg", ImageAlt = "Gmail" }, SectionText = "Rutrum interdum tortor, sed at nulla. A cursus bibendum elit purus cras praesent." },
            new() {SectionImage = new() { ImageUrl = "images/tools/trello.svg", ImageAlt = "Trello" }, SectionText = "Congue pellentesque amet, viverra curabitur quam diam scelerisque fermentum urna." },
            new() {SectionImage = new() { ImageUrl = "images/tools/mailchimp.svg", ImageAlt = "Mailchimp" }, SectionText = "A elementum, imperdiet enim, pretium etiam facilisi in aenean quam mauris." },
            new() {SectionImage = new() { ImageUrl = "images/tools/dropbox.svg", ImageAlt = "Dropbox" }, SectionText = "Ut in turpis consequat odio diam lectus elementum. Est faucibus blandit platea." },
            new() {SectionImage = new() { ImageUrl = "images/tools/evernote.svg", ImageAlt = "Evernote" }, SectionText = "Faucibus cursus maecenas lorem cursus nibh. Sociis sit risus id. Sit facilisis dolor arcu." },
            ]
    };
}
