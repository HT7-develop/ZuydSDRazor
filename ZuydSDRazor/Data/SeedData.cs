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
        if (context.Onderwerpen.Any() || context.Videos.Any() )
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
                    Link = "https://www.youtube.com/embed/gNd5c2C8Doc",
                    Titel = "Spinning Back Fist",
                },

                new Video
                {
                    Link = "https://www.youtube.com/embed/NMGFwBM7Uo4",
                    Titel = "Shooting"
                },

                new Video
                {
                    Link = "https://www.youtube.com/embed/Mgb8wujuit0",
                    Titel = "Side Kick 4.3"
                },
                new Video
                {
                    Link = "https://www.youtube.com/embed/Nz7mAvVysrI",
                    Titel = "Slipping and Evading 3.6"
                },

                new Video
                {
                    Link = "https://www.youtube.com/embed/ocqFWvSVOLc",
                    Titel = "The Hook 3.2"
                },

                new Video
                {
                    Link = "https://www.youtube.com/embed/uVsfBos88CI",
                    Titel = "The Jab 3.1"
                },
                new Video
                {
                    Link = "https://www.youtube.com/embed/QoL2fQDCPas",
                    Titel = "The Uppercut 3.3"
                },

                new Video
                {
                    Link = "https://www.youtube.com/embed/1Wzi6j1REWI",
                    Titel = "Deadly CombinaDons 3.4"
                },

                new Video
                {
                    Link = "https://www.youtube.com/embed/lDMZximoLmk",
                    Titel = "Uithoudingsvermogen(NL) 1.4"
                },
                new Video
                {
                    Link = "https://www.youtube.com/embed/G5mJKBT4HH4",
                    Titel = "Small series of different exercises forcombat stamina"
                },
                new Video
                {
                    Link = "https://www.youtube.com/embed/vr4Mwf0Ymm8",
                    Titel = "Voetenwerk (NL) 1.3"
                },

                new Video
                {
                    Link = "https://www.youtube.com/embed/iygxaot9Vms",
                    Titel = "Flying Front Kick 4.8"
                },
                new Video
                {
                    Link = "https://www.youtube.com/embed/cRX5-wS4M8s",
                    Titel = "Roundhouse kick 4.2"
                },

                new Video
                {
                    Link = "https://www.youtube.com/embed/aRGVRt-i9ww",
                    Titel = "Vicious CombinaDons 4.6"
                },

                new Video
                {
                    Link = "https://www.youtube.com/embed/Sa3_tBJXSSg",
                    Titel = "Jo Bonten - Wat te doen bij een terrorisDsche aanslag"
                },
                new Video
                {
                    Link = "https://www.youtube.com/embed/SJ6gUtVuMWE",
                    Titel = "Zo SCHUIL je voor KOGELS | Man BijtHond | KIJK"
                },
                new Video
                {
                    Link = "https://www.youtube.com/embed/EvJSNf75Ouw",
                    Titel = "HeadbuL"
                }
             );

        context.SaveChanges();

        //context.Koppels.AddRange(

        //new Koppel { Id = 1, VideoId = 1, OnderwerpId = 4 },
        //new Koppel { Id = 2, VideoId = 2, OnderwerpId = 3 },
        //new Koppel { Id = 3, VideoId = 3, OnderwerpId = 2 },
        //new Koppel { Id = 4, VideoId = 3, OnderwerpId = 7 },
        //new Koppel { Id = 5, VideoId = 4, OnderwerpId = 3 },
        //new Koppel { Id = 6, VideoId = 5, OnderwerpId = 10 },
        //new Koppel { Id = 7, VideoId = 6, OnderwerpId = 8 },
        //new Koppel { Id = 8, VideoId = 6, OnderwerpId = 9 },
        //new Koppel { Id = 9, VideoId = 7, OnderwerpId = 8 },
        //new Koppel { Id = 10, VideoId = 8, OnderwerpId = 8 },
        //new Koppel { Id = 11, VideoId = 8, OnderwerpId = 9 },
        //new Koppel { Id = 12, VideoId = 8, OnderwerpId = 10 },
        //new Koppel { Id = 13, VideoId = 9, OnderwerpId = 1 },
        //new Koppel { Id = 14, VideoId = 10, OnderwerpId = 1 },
        //new Koppel { Id = 15, VideoId = 11, OnderwerpId = 3 },
        //new Koppel { Id = 16, VideoId = 11, OnderwerpId = 6 },
        //new Koppel { Id = 17, VideoId = 12, OnderwerpId = 6 },
        //new Koppel { Id = 18, VideoId = 13, OnderwerpId = 7 },
        //new Koppel { Id = 19, VideoId = 14, OnderwerpId = 2 },
        //new Koppel { Id = 20, VideoId = 14, OnderwerpId = 5 },
        //new Koppel { Id = 21, VideoId = 14, OnderwerpId = 6 },
        //new Koppel { Id = 22, VideoId = 14, OnderwerpId = 7 },
        //new Koppel { Id = 23, VideoId = 15, OnderwerpId = 3 },
        //new Koppel { Id = 24, VideoId = 16, OnderwerpId = 3 },
        //new Koppel { Id = 25, VideoId = 17, OnderwerpId = 3 }
        //);
        //context.SaveChanges();

    }
}
