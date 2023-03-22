using System;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using ZuydSDRazor.Data;
using ZuydSDRazor.Models;

namespace StudentenDatabase.Models;


public static class SeedData
{
    public static void Initialize(BontenDbContext context)
    {
        if (/*context.Koppelingen.Any() ||*/ context.Onderwerpen.Any() || context.Videos.Any())
        {
            return;
        }


        context.Onderwerpen.AddRange(
                new Onderwerp
                {
                    Beschrijving = "Stamina",
                },

                new Onderwerp
                {
                    Beschrijving = "Side Kick",
                },

                new Onderwerp
                {
                    Beschrijving = "Ontwijking van gevaar",
                },
                  new Onderwerp
                  {
                      Beschrijving = "Back Fist",
                  },

                new Onderwerp
                {
                    Beschrijving = "Back Kick",
                },

                new Onderwerp
                {
                    Beschrijving = "Front Kick",
                },
                  new Onderwerp
                  {
                      Beschrijving = "RoundHouse Kick",
                  },

                new Onderwerp
                {
                    Beschrijving = "Uppercut",
                },

                new Onderwerp
                {
                    Beschrijving = "The Jab",
                },
                 new Onderwerp
                 {
                     Beschrijving = "The Hook",
                 }
             );

        context.SaveChanges();

        context.Videos.AddRange(

                new Video
                {
                    Link = "hLps://www.youtube.com/embed/gNd5c2C8Doc",
                    Titel = "Spinning Back Fist"
                },

                new Video
                {
                    Link = "hLps://www.youtube.com/embed/NMGFwBM7Uo4",
                    Titel = "ShooDng"
                },

                new Video
                {
                    Link = "hLps://www.youtube.com/embed/Mgb8wujuit0",
                    Titel = "Side Kick 4.3"
                },
                     new Video
                     {
                         Link = "hLps://www.youtube.com/embed/Nz7mAvVysrI",
                         Titel = "Slipping and Evading 3.6"
                     },

                new Video
                {
                    Link = "hLps://www.youtube.com/embed/ocqFWvSVOLc",
                    Titel = "The Hook 3.2"
                },

                new Video
                {
                    Link = "hLps://www.youtube.com/embed/uVsfBos88CI",
                    Titel = "The Jab 3.1"
                },
                     new Video
                     {
                         Link = "hLps://www.youtube.com/embed/QoL2fQDCPas",
                         Titel = "The Uppercut 3.3"
                     },

                new Video
                {
                    Link = "hLps://www.youtube.com/embed/1Wzi6j1REWI",
                    Titel = "Deadly CombinaDons 3.4"
                },

                new Video
                {
                    Link = "hLps://www.youtube.com/embed/lDMZximoLmk",
                    Titel = "Uithoudingsvermogen(NL) 1.4"
                },
                     new Video
                     {
                         Link = "hLps://www.youtube.com/embed/G5mJKBT4HH4",
                         Titel = "Small series of different exercises forcombat stamina"
                     },
                new Video
                {
                    Link = "hLps://www.youtube.com/embed/vr4Mwf0Ymm8",
                    Titel = "Voetenwerk (NL) 1.3"
                },

                new Video
                {
                    Link = "hLps://www.youtube.com/embed/iygxaot9Vms",
                    Titel = "Flying Front Kick 4.8"
                },
                     new Video
                     {
                         Link = "hLps://www.youtube.com/embed/cRX5-wS4M8s",
                         Titel = "Roundhouse kick 4.2"
                     },

                new Video
                {
                    Link = "hLps://www.youtube.com/embed/aRGVRt-i9ww",
                    Titel = "Vicious CombinaDons 4.6"
                },

                new Video
                {
                    Link = "hLps://www.youtube.com/embed/Sa3_tBJXSSg",
                    Titel = "Jo Bonten - Wat te doen bij een terrorisDsche aanslag"
                },
                             new Video
                             {
                                 Link = "hLps://www.youtube.com/embed/SJ6gUtVuMWE",
                                 Titel = "Zo SCHUIL je voor KOGELS | Man BijtHond | KIJK"
                             },
                                          new Video
                                          {
                                              Link = "hLps://www.youtube.com/embed/EvJSNf75Ouw",
                                              Titel = "HeadbuL"
                                          }
             );

        context.SaveChanges();

    }
}
