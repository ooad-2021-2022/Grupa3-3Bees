using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace SarajevoEvents.Models
{
    public static class SeedData // za unošenje nekih podataka pri pokretanju aplikacije
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDataContext>>()))
            {

                if (context.Dogadjaj.Any())
                {
                    return;   // DB has been seeded
                }

                if (!context.PoslovniKorisnik.Any())
                {
                    context.PoslovniKorisnik.AddRange(
                    new PoslovniKorisnik
                    {
                        brojNagradnihBodova = 10,
                        brojTelefona = "062625894",
                        email = "mail1@gmail.com",
                        ime = "Wine",
                        prezime = "Fest",
                        nazivKorisnika = "wfs",
                        lozinka = "hashswfs",
                        ID = 1
                    },

                    new PoslovniKorisnik
                    {
                        brojNagradnihBodova = 10,
                        brojTelefona = "033265974",
                        email = "mail2@gmail.com",
                        ime = "Sarajevo",
                        prezime = "FilmFestival",
                        nazivKorisnika = "sff",
                        lozinka = "hashsff",
                        ID = 2
                    },

                    new PoslovniKorisnik
                    {
                        brojNagradnihBodova = 10,
                        brojTelefona = "06218591654",
                        email = "mail3@gmail.com",
                        ime = "Sarajevo",
                        prezime = "Matinee",
                        nazivKorisnika = "smee",
                        lozinka = "hashsmee",
                        ID = 3
                    }
                );
                }



                // Look for any movies.

                context.Dogadjaj.AddRange(
                    new Dogadjaj
                    {
                        IDPoslovniKorisnik = 2,
                        potrebnaKarta = true,
                        potrebnaRezervacija = true,
                        vrstaDogadjaja = VrstaDogadjaja.Kino,
                        brojNagradnihBodova = 5,
                        cijenaKarte = 50,
                        datumOdrzavanja = DateTime.Parse("2022-08-12")
                    },

                    new Dogadjaj
                    {
                        IDPoslovniKorisnik = 1,
                        potrebnaKarta = true,
                        potrebnaRezervacija = true,
                        vrstaDogadjaja = VrstaDogadjaja.Kultura,
                        brojNagradnihBodova = 15,
                        cijenaKarte = 50,
                        datumOdrzavanja = DateTime.Parse("2022-06-12")
                    },

                    new Dogadjaj
                    {
                        IDPoslovniKorisnik = 3,
                        potrebnaKarta = true,
                        potrebnaRezervacija = false,
                        vrstaDogadjaja = VrstaDogadjaja.Muzika,
                        brojNagradnihBodova = 20,
                        cijenaKarte = 7,
                        datumOdrzavanja = DateTime.Parse("2022-07-31")
                    },

                    new Dogadjaj
                    {
                        IDPoslovniKorisnik = 3,
                        potrebnaKarta = true,
                        potrebnaRezervacija = false,
                        vrstaDogadjaja = VrstaDogadjaja.Muzika,
                        brojNagradnihBodova = 25,
                        cijenaKarte = 7,
                        datumOdrzavanja = DateTime.Parse("2022-06-23")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}