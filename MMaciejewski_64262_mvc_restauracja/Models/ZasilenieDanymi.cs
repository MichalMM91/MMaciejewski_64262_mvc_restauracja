
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MMaciejewski_64262_mvc_restauracja.Data;
using System;
using System.Linq;

namespace MMaciejewski_64262_mvc_restauracja.Models;
public static class ZasilenieDanymi
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProjectContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ProjectContext>>()))
            {
                // Czy są jakiekolwiek dania w menu.
                if (context.Danie.Any())
                {
                    return;   // DB zasilona
                }

                context.Danie.AddRange(
                    new Danie
                    {
                        Nazwa = "Makaron z grzybami mung",
                        Kategoria = "Dania główne",
                        Dieta = "Vege",
                        Ilość = 250,
                        Cena = 36
                    },

                    new Danie
                    {
                        Nazwa = "Placek po zbójnicku",
                        Kategoria = "Dania główne",
                        Dieta = "Nie-vege",
                        Ilość = 330,
                        Cena = 39
                    },

                    new Danie
                    {
                        Nazwa = "Jajecznica na boczku",
                        Kategoria = "Przystawki",
                        Dieta = "Nie-vege",
                        Ilość = 180,
                        Cena = 27
                    },

                    new Danie
                    {
                        Nazwa = "Tofucznica po bieszczadzku",
                        Kategoria = "Przystawki",
                        Dieta = "Vege",
                        Ilość = 160,
                        Cena = 25
                    },

                    new Danie
                    {
                        Nazwa = "Lin w śmietanie",
                        Kategoria = "Dania główne",
                        Dieta = "Nie-vege",
                        Ilość = 230,
                        Cena = 45
                    }
                );
                context.SaveChanges();
            }
        }
    }
