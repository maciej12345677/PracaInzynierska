using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Grzadka.Models;
using Grzadka.Migrations;
using System.Data.Entity.Migrations;

namespace Grzadka.DAL
{
    public class StoreInitializer:MigrateDatabaseToLatestVersion<StoreContext,Configuration>
    {
        //protected override void Seed(StoreContext context)
        //{
        //    SeedStoreData(context);
        //    base.Seed(context);
        //}

        public static void SeedStoreData(StoreContext context)
        {
            var categories = new List<Category>
            {
                new Category() { CategoryId = 1, Name = "Doniczkowe", IconFileName = "rock.png",Description="Opis kategorii..." },
                new Category() { CategoryId = 2, Name = "Iglaste", IconFileName = "metal.png",Description="Opis kategorii..." },
                new Category() { CategoryId = 3, Name = "Chujowe", IconFileName = "jazz.png",Description="Opis kategorii..." },
                new Category() { CategoryId = 4, Name = "Smierdzace", IconFileName = "pop.png",Description="Opis kategorii..." },
                new Category() { CategoryId = 4, Name = "Pedalskie", IconFileName = "rock.png",Description="Opis kategorii..." },
                new Category() { CategoryId = 4, Name = "Pasztetowe", IconFileName = "metal.png",Description="Opis kategorii..." },
            };
            categories.ForEach(g => context.Categories.AddOrUpdate(g));
            context.SaveChanges();

            var plants = new List<Plant>
            {
                new Plant() { PlantId = 1, PlantName = "Adenium opasłe", StandPoint = 1,Humidity=2,Size=1,Decoration=2,Growth=1,Spitz=2,Rambling=2,Difficulty=3, Price = 19.99M, CoverFileName = "Adenium opasłe _Róża Pustyni_.jpg", IsBestseller = true, DateAdded = new DateTime(2019, 11, 26), CategoryId = 1 },
                new Plant() { PlantId = 2, PlantName = "Aeschynanthus 'Mona Lisa'", StandPoint = 1,Humidity=2,Size=2,Decoration=2,Growth=1,Spitz=1,Rambling=1,Difficulty=1, Price = 21.99M, CoverFileName = "Aeschynanthus _Mona Lisa_.jpg", IsBestseller = true, DateAdded = new DateTime(2019, 11, 26), CategoryId = 2 },
                new Plant() { PlantId = 3, PlantName = "Aloes", StandPoint = 1,Humidity=2,Size=2,Decoration=1,Growth=1,Spitz=2,Rambling=2,Difficulty=1, Price = 9.99M, CoverFileName = "aloes.jpg", IsBestseller = false, DateAdded = new DateTime(2019, 11, 26), CategoryId = 3 },
                new Plant() { PlantId = 4, PlantName = "Cissus australijski", StandPoint =3 ,Humidity=2,Size=3,Decoration=1,Growth=2,Spitz=2,Rambling=1,Difficulty=1, Price = 26.99M, CoverFileName = "Cissus australijski.jpg", IsBestseller = false, DateAdded = new DateTime(2019, 11, 26), CategoryId = 4 }
            };

            plants.ForEach(a => context.Plants.AddOrUpdate(a));
            context.SaveChanges();
        }

        //internal static void SeedStoreData(StoreContext context)
        //{
        //    throw new NotImplementedException();
        //}
    }
}