using WebApp.Models.Components;

namespace WebApp.ViewModels.Components
{
    public class CourseBoxViewModel
    {
        public ImageViewModel Image { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public string Price { get; set; } = null!;
        public string? DiscountedPrice { get; set; }
        public string Hours { get; set; } = null!;
        public string LikesPercent { get; set; } = null!;
        public string Likes { get; set; } = null!;
        public bool IsBestseller { get; set; } = false;
    }
}
