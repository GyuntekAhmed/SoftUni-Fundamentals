﻿namespace Homies.Models.Event
{
    public class EventAllViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public DateTime Start { get; set; }

        public string Type { get; set; } = null!;

        public string Organaizer { get; set; } = null!;
    }
}
