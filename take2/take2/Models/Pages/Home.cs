using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace take2.Models.Pages
{
    [ContentType(DisplayName = "DefaultPage1", GUID = "dce696bb-2ad6-43f6-b1d0-70bcd1d05d97", Description = "")]
    public class Home : PageData
    {
        [CultureSpecific]
        [Display(
            Name = "Heading",
            Description = "Heading.",
            GroupName = SystemTabNames.Content,
            Order = 0)]
        public virtual XhtmlString Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

    }
}