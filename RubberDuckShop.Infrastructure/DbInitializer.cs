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
           // ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();

            DuckColor dcol1 = ctx.DuckColors.Add(new DuckColor()
            {
                ID = 1,
                Name = "Yellow"
            }).Entity;

            DuckColor dcol2 = ctx.DuckColors.Add(new DuckColor()
            {
                ID = 2,
                Name = "Red"
            }).Entity;

            DuckColor dcol3 = ctx.DuckColors.Add(new DuckColor()
            {
                ID = 3,
                Name = "Green"
            }).Entity;

            DuckColor dcol4 = ctx.DuckColors.Add(new DuckColor()
            {
                ID = 4,
                Name = "Black"
            }).Entity;

            DuckColor dcol5 = ctx.DuckColors.Add(new DuckColor()
            {
                ID = 5,
                Name = "Brown"
            }).Entity;

            DuckColor dcol6 = ctx.DuckColors.Add(new DuckColor()
            {
                ID = 6,
                Name = "Pink"
            }).Entity;

            DuckPattern dpat1 = ctx.DuckPatterns.Add(new DuckPattern()
            {
                ID = 1,
                Name = "Spotted"
            }).Entity;

            DuckPattern dpat2 = ctx.DuckPatterns.Add(new DuckPattern()
            {
                ID = 2,
                Name = "Striped"
            }).Entity;

            DuckPattern dpat3 = ctx.DuckPatterns.Add(new DuckPattern()
            {
                ID = 3,
                Name = "No Pattern"
            }).Entity;


            DuckCostume dcost1 = ctx.DuckCostumes.Add(new DuckCostume()
            {
                ID = 1,
                Name = "Navy"
            }).Entity;

            DuckCostume dcost2 = ctx.DuckCostumes.Add(new DuckCostume()
            {
                ID = 2,
                Name = "Thor"
            }).Entity;

            DuckCostume dcost3 = ctx.DuckCostumes.Add(new DuckCostume()
            {
                ID = 3,
                Name = "Jack Sparrow"
            }).Entity;

            DuckCostume dcost4 = ctx.DuckCostumes.Add(new DuckCostume()
            {
                ID = 4,
                Name = "Nurse"
            }).Entity;

            //Random rnd = new Random();

            //for (int i = 0; i < 12; i++)
            //{
            //    int r1 = rnd.Next(1, 6);
            //    int r2 = rnd.Next(1, 3);
            //    int r3 = rnd.Next(1, 4);
            //    int r4 = rnd.Next(1, 4);
            //    int r5 = rnd.Next(1, 2);

            //    ctx.RubberDucks.Add(new RubberDuck() { 
            //        ID = i + 1,
            //        DuckColor = ctx.DuckColors.FirstOrDefault(col => col.ID == r1),
            //        DuckCostume = ctx.DuckCostumes.FirstOrDefault(cos => cos.ID == r2),
            //        DuckPattern = ctx.DuckPatterns.FirstOrDefault(pat => pat.ID == r3),
            //        DuckSize = (DuckSize)r4,
            //        DuckGender = (DuckGender)r5,
            //        Price = rnd.Next(600, 1200)
            //    });
            //}

            ctx.RubberDucks.Add(new RubberDuck() { 
                    ID = 1,
                    DuckColor = dcol1,
                    DuckCostume = dcost1,
                    DuckPattern = dpat1,
                    DuckSize = DuckSize.MEDIUM,
                    DuckGender = DuckGender.FEMALE,
                    Price = 1200
             });

            ctx.RubberDucks.Add(new RubberDuck()
            {
                ID = 2,
                DuckColor = dcol2,
                DuckCostume = dcost1,
                DuckPattern = dpat2,
                DuckSize = DuckSize.LARGE,
                DuckGender = DuckGender.MALE,
                Price = 300
            });

            ctx.RubberDucks.Add(new RubberDuck()
            {
                ID = 3,
                DuckColor = dcol4,
                DuckCostume = dcost3,
                DuckPattern = dpat3,
                DuckSize = DuckSize.MEDIUM,
                DuckGender = DuckGender.FEMALE,
                Price = 561
            });

            ctx.RubberDucks.Add(new RubberDuck()
            {
                ID = 4,
                DuckColor = dcol6,
                DuckCostume = dcost3,
                DuckPattern = dpat3,
                DuckSize = DuckSize.SMALL,
                DuckGender = DuckGender.MALE,
                Price = 786
            });

            ctx.RubberDucks.Add(new RubberDuck()
            {
                ID = 5,
                DuckColor = dcol3,
                DuckCostume = dcost2,
                DuckPattern = dpat1,
                DuckSize = DuckSize.SMALL,
                DuckGender = DuckGender.FEMALE,
                Price = 987
            });

            ctx.RubberDucks.Add(new RubberDuck()
            {
                ID = 6,
                DuckColor = dcol6,
                DuckCostume = dcost2,
                DuckPattern = dpat2,
                DuckSize = DuckSize.MEDIUM,
                DuckGender = DuckGender.MALE,
                Price = 678
            });

            ctx.RubberDucks.Add(new RubberDuck()
            {
                ID = 7,
                DuckColor = dcol1,
                DuckCostume = dcost2,
                DuckPattern = dpat3,
                DuckSize = DuckSize.XXL,
                DuckGender = DuckGender.MALE,
                Price = 1043
            });

            ctx.RubberDucks.Add(new RubberDuck()
            {
                ID = 8,
                DuckColor = dcol5,
                DuckCostume = dcost4,
                DuckPattern = dpat3,
                DuckSize = DuckSize.XXL,
                DuckGender = DuckGender.FEMALE,
                Price = 1000
            });

            ctx.RubberDucks.Add(new RubberDuck()
            {
                ID = 9,
                DuckColor = dcol2,
                DuckCostume = dcost2,
                DuckPattern = dpat2,
                DuckSize = DuckSize.XXL,
                DuckGender = DuckGender.MALE,
                Price = 876
            });

            ctx.RubberDucks.Add(new RubberDuck()
            {
                ID = 10,
                DuckColor = dcol2,
                DuckCostume = dcost3,
                DuckPattern = dpat2,
                DuckSize = DuckSize.MEDIUM,
                DuckGender = DuckGender.FEMALE,
                Price = 666
            });

            ctx.RubberDucks.Add(new RubberDuck()
            {
                ID = 11,
                DuckColor = dcol3,
                DuckCostume = dcost2,
                DuckPattern = dpat1,
                DuckSize = DuckSize.LARGE,
                DuckGender = DuckGender.FEMALE,
                Price = 1123
            });

            ctx.RubberDucks.Add(new RubberDuck()
            {
                ID = 12,
                DuckColor = dcol4,
                DuckCostume = dcost1,
                DuckPattern = dpat1,
                DuckSize = DuckSize.LARGE,
                DuckGender = DuckGender.MALE,
                Price = 876
            });

            ctx.SaveChanges();
        }
    }
}
