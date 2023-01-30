using System.ComponentModel.DataAnnotations;

namespace MMaciejewski_64262_mvc_restauracja.Models;


public class Danie
{
    public int Id { get; set; }
    public string Nazwa { get; set; }
    public string Kategoria { get; set; }
    public string Dieta { get; set; }
    [Display(Name = "Ilość (ml / g)")] 
    public int Ilość { get; set; }
    [Display(Name = "Cena (PLN)")] 
    public int Cena { get; set; }
}
