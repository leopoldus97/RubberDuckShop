using RubberDuckShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RubberDuckShop.Infrastructure
{
    public class DbInitializer
    {
        public static void Seed(RubberDuckShopContext ctx)
        {
            ctx.Database.EnsureCreated();

            DuckColor dcol1 = ctx.duckColor.Add(new DuckColor()
            {
                ID = 1,
                Name = "Yellow"
            }).Entity;

            DuckColor dcol2 = ctx.duckColor.Add(new DuckColor()
            {
                ID = 2,
                Name = "Red"
            }).Entity;

            DuckColor dcol3 = ctx.duckColor.Add(new DuckColor()
            {
                ID = 3,
                Name = "Green"
            }).Entity;

            DuckColor dcol4 = ctx.duckColor.Add(new DuckColor()
            {
                ID = 4,
                Name = "Black"
            }).Entity;

            DuckColor dcol5 = ctx.duckColor.Add(new DuckColor()
            {
                ID = 5,
                Name = "Brown"
            }).Entity;

            DuckColor dcol6 = ctx.duckColor.Add(new DuckColor()
            {
                ID = 6,
                Name = "Pink"
            }).Entity;

            DuckPattern dpat1 = ctx.duckPattern.Add(new DuckPattern()
            {
                ID = 1,
                Name = "Spotted"
            }).Entity;

            DuckPattern dpat2 = ctx.duckPattern.Add(new DuckPattern()
            {
                ID = 2,
                Name = "Striped"
            }).Entity;

            DuckPattern dpat3 = ctx.duckPattern.Add(new DuckPattern()
            {
                ID = 3,
                Name = "No Pattern"
            }).Entity;


            DuckCostume dcost1 = ctx.duckCostume.Add(new DuckCostume()
            {
                ID = 1,
                Name = "Navy"
            }).Entity;

            DuckCostume dcost2 = ctx.duckCostume.Add(new DuckCostume()
            {
                ID = 2,
                Name = "Thor"
            }).Entity;

            DuckCostume dcost3 = ctx.duckCostume.Add(new DuckCostume()
            {
                ID = 3,
                Name = "Jack Sparrow"
            }).Entity;

            DuckCostume dcost4 = ctx.duckCostume.Add(new DuckCostume()
            {
                ID = 4,
                Name = "Nurse"
            }).Entity;


            Random rnd = new Random();

            for (int i = 0; i < 12; i++)
            {
                ctx.rubberDucks.Add(new RubberDuck() { 
                    ID = i,
                    DuckColor = ctx.duckColor.FirstOrDefault(col => col.ID == rnd.Next(0, 5)),
                    DuckCostume = ctx.duckCostume.FirstOrDefault(cos => cos.ID == rnd.Next(0, 3)),
                    DuckPattern = ctx.duckPattern.FirstOrDefault(pat => pat.ID == rnd.Next(0, 3)),
                    DuckSize = (DuckSize) rnd.Next(1, 4),
                    DuckGender = (DuckGender) rnd.Next(1, 2),
                    Price = rnd.Next(600, 1200)
                });
            }

            ctx.SaveChanges();
        }
    }
}
