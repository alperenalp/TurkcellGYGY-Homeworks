﻿namespace Movies.Application
{
    public class CreateNewPlayerRequest
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string? Info { get; set; }
    }
}