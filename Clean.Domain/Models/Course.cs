using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Clean.Domain.Models
{
    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string DescriptionAttribute { get; set; }

        public string ImagenURL { get; set; }
    }
}
