﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Web.Models;

namespace Portfolio.Web.ViewComponents;

public class HeroSectionViewComponent(IHeroSectionService heroSectionService, ISocialLinkService socialLinkService) : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var heroSection = await heroSectionService.GetAllVisibleAsync();
        var socialLinks = await socialLinkService.GetAllVisibleAsync();

        var heroSectionViewModel = new HeroSectionViewModel
        {
            HeroSection = heroSection.FirstOrDefault(),
            SocialLinkDtos = socialLinks
        };

        return View(heroSectionViewModel);
    }
}

