﻿namespace PhotoShare.Models
{
    public class Photo
    {
        // Primary key
        public int PhotoId { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }

        public string ImageFilename { get; set; } = string.Empty;

        public bool IsPublic { get; set; } = false;

        // Navigation property
        public List<Photo>? Tags { get; set; } // nullable!!
    }
}
