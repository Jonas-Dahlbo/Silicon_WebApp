using Microsoft.AspNetCore.Mvc;
using WebApp.Models.Components;
using WebApp.Models.Sections;
using WebApp.Models.Views;

namespace WebApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var viewModel = new HomeIndexViewModel
        {
            Title = "Ultimate Task Manager",
            Showcase = new ShowcaseViewModel
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
            }
        };

        ViewData["Title"] = viewModel.Title;
        return View(viewModel);
    }
}
