﻿using System.ComponentModel.DataAnnotations;

namespace Client.ImageGallery.Model
{
    public class ImageForUpdate
    {
        [Required]
        [MaxLength(150)]
        public string Title { get; set; }

        public ImageForUpdate(string title)
        {
            Title = title;
        }
    }
}
