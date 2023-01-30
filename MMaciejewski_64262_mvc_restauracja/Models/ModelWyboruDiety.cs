using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MMaciejewski_64262_mvc_restauracja.Models
{
    public class ModelWyboruDiety
    {
        public List<Danie>? Dania { get; set; }
        public SelectList? Diety { get; set; }
        public string? DietaDania { get; set; }
        public string? SearchString { get; set; }
    }
}
