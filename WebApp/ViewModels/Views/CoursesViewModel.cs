using WebApp.ViewModels.Components;

namespace WebApp.ViewModels.Views;

public class CoursesViewModel
{
    public string Title { get; set; } = "Courses";
    public List<string> Category { get; set; } = [
        "Frontend",
        "Fullstack",
        "Data science"
    ];
    public List<CourseBoxViewModel> CourseBox { get; set; } = [
        new() { IsBestseller = true, Image = new(){ ImageUrl = "images/courses/course1.svg", ImageAlt = "" }, Title = "Fullstack Web Developer Course from Scratch", Author = "By Robert Fox", Price = "$12.50", Hours = "220 hours", LikesPercent = "94%", Likes = "4.2K" },
        new() { Image = new(){ ImageUrl = "images/courses/course2.svg", ImageAlt = "" }, Title = "HTML, CSS, JavaScript Web Developer", Author = "By Jenny Wilson & Marvin McKinney", Price = "$15.99", Hours = "160 hours", LikesPercent = "92%", Likes = "3.1K" },
        new() { Image = new(){ ImageUrl = "images/courses/course3.svg", ImageAlt = "" }, Title = "The Complete Front-End Web Development Course", Author = "By Albert Flores", DiscountedPrice = "$9.99" , Price = "$44.99", Hours = "100 hours", LikesPercent = "98%", Likes = "2.7K" },
        new() { Image = new(){ ImageUrl = "images/courses/course4.svg", ImageAlt = "" }, Title = "iOS & Swift - The Complete iOS App Development Course", Author = "By Marvin McKinney", Price = "$15.99", Hours = "160 hours", LikesPercent = "92%", Likes = "3.1K" },
        new() { IsBestseller = true,  Image = new(){ ImageUrl = "images/courses/course5.svg", ImageAlt = "" }, Title = "Data Science & Machine Learning with Python", Author = "By Esther Howard", Price = "$11.20", Hours = "160 hours", LikesPercent = "92%", Likes = "3.1K" },
        new() { Image = new(){ ImageUrl = "images/courses/course6.svg", ImageAlt = "" }, Title = "Creative CSS Drawing Course: Make Art With CSS", Author = "By Robert Fox", Price = "$10.50", Hours = "220 hours", LikesPercent = "94%", Likes = "4.2K" },
        new() { Image = new(){ ImageUrl = "images/courses/course7.svg", ImageAlt = "" }, Title = "Blender Character Creator v2.0 for Video Games Design", Author = "By Ralph Edwards", Price = "$18.99", Hours = "160 hours", LikesPercent = "92%", Likes = "3.1K" },
        new() { Image = new(){ ImageUrl = "images/courses/course8.svg", ImageAlt = "" }, Title = "The Ultimate Guide to 2D Mobile Game Development with Unity", Author = "By Albert Flores", DiscountedPrice = "$12.99" , Price = "$44.99", Hours = "100 hours", LikesPercent = "98%", Likes = "2.7K" },
        new() { Image = new(){ ImageUrl = "images/courses/course9.svg", ImageAlt = "" }, Title = "Learn JMETER from Scratch on Live Apps-Performance Testing", Author = "By Jenny Wilson", Price = "$14.50", Hours = "160 hours", LikesPercent = "92%", Likes = "3.1K" },
    ];
}
