﻿namespace Layers.Core.Models
{
    public class User : BaseModel
	{
        // User Entities

        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
