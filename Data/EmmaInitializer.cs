﻿using EmmaProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EmmaProject.Data
{
    public class EmmaInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            EmmaProjectContext context = applicationBuilder.ApplicationServices.CreateScope()
                .ServiceProvider.GetRequiredService<EmmaProjectContext>();
            try
            {
                //If the migration update has an issue, uncomment the line of code below, execute the project, close the project and comment this line back...
                //context.Database.EnsureDeleted();

                context.Database.Migrate();

                //Seeding data for Employees
                if (!context.Employees.Any())
                {
                    context.Employees.AddRange(
                        new Employee
                        {
                            EmpFirst = "Eileen",
                            EmpLast = "Welsh",
                            EmpUserName = "EWelsh",
                            EmpPassword = "Password"
                        },

                        new Employee
                        {
                            EmpFirst = "Gabrielle",
                            EmpLast = "Vallieres",
                            EmpUserName = "GVallieres",
                            EmpPassword = "Password"
                        },

                        new Employee
                        {
                            EmpFirst = "Jasmine",
                            EmpLast = "Ramsay",
                            EmpUserName = "JRamsay",
                            EmpPassword = "Password"
                        },

                        new Employee
                        {
                            EmpFirst = "Vince",
                            EmpLast = "Reid",
                            EmpUserName = "VReid",
                            EmpPassword = "Password"
                        },

                        new Employee
                        {
                            EmpFirst = "Clement",
                            EmpLast = "Carr",
                            EmpUserName = "CCarr",
                            EmpPassword = "Password"
                        },

                        new Employee
                        {
                            EmpFirst = "Carlo",
                            EmpLast = "Brisebois",
                            EmpUserName = "CBrisebois",
                            EmpPassword = "Password"
                        },

                        new Employee
                        {
                            EmpFirst = "Fernand",
                            EmpLast = "McFarlane",
                            EmpUserName = "FMcFarlane",
                            EmpPassword = "Password"
                        },

                        new Employee
                        {
                            EmpFirst = "Julia",
                            EmpLast = "St-Pierre",
                            EmpUserName = "JStPierre",
                            EmpPassword = "Password"
                        },

                        new Employee
                        {
                            EmpFirst = "Judy",
                            EmpLast = "Dumas",
                            EmpUserName = "JDumas",
                            EmpPassword = "Password"
                        },

                        new Employee
                        {
                            EmpFirst = "Chad",
                            EmpLast = "Rodrigue",
                            EmpUserName = "CRodrigue",
                            EmpPassword = "Password"
                        });
                    context.SaveChanges();
                }
                //Seeding data for Customers
                if (!context.Customers.Any())
                {
                    context.Customers.AddRange(
                        new Customer
                        {
                            CustFirst = "Ben",
                            CustLast = "Audet",
                            CustPhone = "2638746671",
                            CustAddress = "3400 Center St",
                            CustCity = "Vulcan",
                            CustProvince = "AB",
                            CustPostal = "T0L 2B0"
                        },
                        new Customer
                        {
                            CustFirst = "Jean",
                            CustLast = "Legault",
                            CustPhone = "4034700566",
                            CustAddress = "1217 Islington Ave",
                            CustCity = "Toronto",
                            CustProvince = "ON",
                            CustPostal = "M8V 3B6"
                        },
                        new Customer
                        {
                            CustFirst = "Sylvie",
                            CustLast = "Wall",
                            CustPhone = "2043810624",
                            CustAddress = "1752 St Jean Baptiste St",
                            CustCity = "St Prosper De Dorchester",
                            CustProvince = "QC",
                            CustPostal = "G0M 1Y0"
                        },
                        new Customer
                        {
                            CustFirst = "Clayton",
                            CustLast = "Langlois",
                            CustPhone = "3436471532",
                            CustAddress = "4474 Toy Avenue",
                            CustCity = "Ajax Pickering",
                            CustProvince = "ON",
                            CustPostal = "L1W 3N9"
                        },
                        new Customer
                        {
                            CustFirst = "Leo",
                            CustLast = "Lepine",
                            CustPhone = "5194440181",
                            CustAddress = "794 Jade St",
                            CustCity = "Richmond",
                            CustProvince = "BC",
                            CustPostal = "V7E 2E4"
                        },
                        new Customer
                        {
                            CustFirst = "Dominique",
                            CustLast = "Milne",
                            CustPhone = "2899957489",
                            CustAddress = "3833 White Point Road",
                            CustCity = "Shelburne",
                            CustProvince = "NS",
                            CustPostal = "B0T 1W0"
                        },
                        new Customer
                        {
                            CustFirst = "Wanda",
                            CustLast = "Deslauriers",
                            CustPhone = "2893238002",
                            CustAddress = "4146 Bay Street",
                            CustCity = "Toronto",
                            CustProvince = "ON",
                            CustPostal = "M5J 2R8"
                        },
                        new Customer
                        {
                            CustFirst = "Sheri",
                            CustLast = "Han",
                            CustPhone = "3438772169",
                            CustAddress = "220 A Avenue",
                            CustCity = "Edmonton",
                            CustProvince = "AB",
                            CustPostal = "T5J 0K7"
                        },
                        new Customer
                        {
                            CustFirst = "Alexander",
                            CustLast = "Onge",
                            CustPhone = "2496322220",
                            CustAddress = "3872 Sixth Street",
                            CustCity = "New Westminster",
                            CustProvince = "BC",
                            CustPostal = "V3L 3C1"
                        },
                        new Customer
                        {
                            CustFirst = "Emma",
                            CustLast = "Mohammed",
                            CustPhone = "2364725460",
                            CustAddress = "1136 Granville St",
                            CustCity = "Halifax",
                            CustProvince = "NS",
                            CustPostal = "B3K 1N7"
                        });
                    context.SaveChanges();
                }
                //Seeding data for Inventory
                if (!context.Inventories.Any())
                {
                    context.Inventories.AddRange(
                        new Inventory
                        {
                            UPC_ID = "123-4567-8",
                            InvName = "Mower Blade",
                            InvSize = "(S) - 8\" Length x 4\" Width",
                            InvQuantity = "3-Pack",
                            InvAdjustedPrice = 10.99M,
                            InvMarkupPrice = 13.99M,
                            InvCurrent = 'Y'

                        },
                        new Inventory
                        {
                            UPC_ID = "234-5678-9",
                            InvName = "Saw Blade",
                            InvSize = "(L) - 12\' Length x 5\' Width",
                            InvQuantity = "3-Pack",
                            InvAdjustedPrice = 13.00M,
                            InvMarkupPrice = 15.99M,
                            InvCurrent = 'Y'
                        },
                        new Inventory
                        {
                            UPC_ID = "345-6789-0",
                            InvName = "Atlas Lawnmower Engine Brake Cable",
                            InvSize = "54\" (137 cm) cable",
                            InvQuantity = "1",
                            InvAdjustedPrice = 6.99M,
                            InvMarkupPrice = 8.99M,
                            InvCurrent = 'N'
                        },
                        new Inventory
                        {
                            UPC_ID = "456-7890-1",
                            InvName = "Champion 224cc OHV Horizontal Gas Engine",
                            InvSize = "Shaft dimensions (D x L): 2.4 D x 3/4\" D",
                            InvQuantity = "1",
                            InvAdjustedPrice = 97.99M,
                            InvMarkupPrice = 113.99M,
                            InvCurrent = 'N'
                        },
                        new Inventory
                        {
                            UPC_ID = "567-8901-2",
                            InvName = "MTD Replacement Blade Adapter",
                            InvSize = "Fits 7/8\" crankshaft with 3/16\" key",
                            InvQuantity = "1",
                            InvAdjustedPrice = 15.99M,
                            InvMarkupPrice = 18.99M,
                            InvCurrent = 'Y'
                        },
                        new Inventory
                        {
                            UPC_ID = "678-9012-3",
                            InvName = "Mower Sulky Caster Wheels",
                            InvSize = "11\" pneumatic caster wheels",
                            InvQuantity = "1",
                            InvAdjustedPrice = 91.99M,
                            InvMarkupPrice = 122.99M,
                            InvCurrent = 'Y'
                        },
                        new Inventory
                        {
                            UPC_ID = "789-0123-4",
                            InvName = "Starter Rope W/Handle",
                            InvSize = "4.5 mm Rope. 43\" Long (110cm)",
                            InvQuantity = "3-Pack",
                            InvAdjustedPrice = 5.99M,
                            InvMarkupPrice = 6.99M,
                            InvCurrent = 'N'
                        },
                        new Inventory
                        {
                            UPC_ID = "890-1234-5",
                            InvName = "Proslide XT Gas Spring",
                            InvSize = "6mm-15mm",
                            InvQuantity = "3-Pack",
                            InvAdjustedPrice = 12.99M,
                            InvMarkupPrice = 15.99M,
                            InvCurrent = 'N'
                        },
                        new Inventory
                        {
                            UPC_ID = "901-2345-6",
                            InvName = "Walker 6610 Dethatcher Tines For A10",
                            InvSize = "WIDTH: 4\" THICKNESS: 0.1600\" OVERALL LENGTH: 8\"",
                            InvQuantity = "20",
                            InvAdjustedPrice = 86.99M,
                            InvMarkupPrice = 100.99M,
                            InvCurrent = 'Y'
                        },
                        new Inventory
                        {
                            UPC_ID = "012-3456-7",
                            InvName = "Battery Powered Sprayer",
                            InvSize = "4 Gallons",
                            InvQuantity = "1",
                            InvAdjustedPrice = 42.99M,
                            InvMarkupPrice = 49.99M,
                            InvCurrent = 'Y'
                        });
                    context.SaveChanges();
                }
                if (!context.Prices.Any())
                {
                    context.Prices.AddRange(
                        new Price
                        {
                            UPC_ID = "123-4567-8",
                            PricePurchasedCost = 55.55M,
                            PricePurchasedDate = new DateOnly(2022, 10, 19),
                            PriceCount = 50
                        },
                        new Price
                        {
                            UPC_ID = "123-4567-8",
                            PricePurchasedCost = 45.55M,
                            PricePurchasedDate = new DateOnly(2022, 10, 19),
                            PriceCount = 50
                        },
                        new Price
                        {
                            UPC_ID = "123-4567-8",
                            PricePurchasedCost = 65.55M,
                            PricePurchasedDate = new DateOnly(2022, 10, 19),
                            PriceCount = 50
                        },
                        new Price
                        {
                            UPC_ID = "345-4567-8",
                            PricePurchasedCost = 75.55M,
                            PricePurchasedDate = new DateOnly(2022, 10, 19),
                            PriceCount = 50
                        },
                        new Price
                        {
                            UPC_ID = "123-4527-9",
                            PricePurchasedCost = 45.55M,
                            PricePurchasedDate = new DateOnly(2022, 10, 19),
                            PriceCount = 50
                        },
                        new Price
                        {
                            UPC_ID = "223-4567-8",
                            PricePurchasedCost = 85.55M,
                            PricePurchasedDate = new DateOnly(2022, 10, 19),
                            PriceCount = 50
                        },
                        new Price
                        {
                            UPC_ID = "333-4567-8",
                            PricePurchasedCost = 95.55M,
                            PricePurchasedDate = new DateOnly(2022, 10, 19),
                            PriceCount = 50
                        },
                        new Price
                        {
                            UPC_ID = "444-4567-8",
                            PricePurchasedCost = 25.55M,
                            PricePurchasedDate = new DateOnly(2022, 10, 19),
                            PriceCount = 50
                        },
                        new Price
                        {
                            UPC_ID = "123-4567-8",
                            PricePurchasedCost = 15.55M,
                            PricePurchasedDate = new DateOnly(2022, 10, 19),
                            PriceCount = 50
                        },
                        new Price
                        {
                            UPC_ID = "123-4567-8",
                            PricePurchasedCost = 5.55M,
                            PricePurchasedDate = new DateOnly(2022, 10, 19),
                            PriceCount = 75
                        });
                    context.SaveChanges();
                }
                //Seeding data for Suppliers
                if (!context.Suppliers.Any())
                {
                    context.Suppliers.AddRange(
                        new Supplier
                        {
                            SupName = "Jason Momoa",
                            SupPhone = "3439787551",
                            SupEmail = "jasonm@domain.ca",
                            SupAddress = "1251 Kinchant St",
                            SupCity = "Quesnel",
                            SupProvince = "BC",
                            SupPostal = "V2J 2R5"
                        },
                        new Supplier
                        {
                            SupName = "Cherry Fox",
                            SupPhone = "5142935101",
                            SupEmail = "cherryfox2023@domain.ca",
                            SupAddress = "2883 Duke Street",
                            SupCity = "Montreal",
                            SupProvince = "QC",
                            SupPostal = "H3C 5K4"
                        },
                        new Supplier
                        {
                            SupName = "Janet's Workshop",
                            SupPhone = "2268239976",
                            SupEmail = "janetedmonton@domain.ca",
                            SupAddress = "1329 137th Avenue",
                            SupCity = "Edmonton",
                            SupProvince = "AB",
                            SupPostal = "T5J 2Z2"
                        },
                        new Supplier
                        {
                            SupName = "Myrna Milne",
                            SupPhone = "7059770898",
                            SupEmail = "milnem1@domain.ca",
                            SupAddress = "557 rue Saint-Antoine",
                            SupCity = "Granby",
                            SupProvince = "QC",
                            SupPostal = "J2H 2H5"
                        },
                        new Supplier
                        {
                            SupName = "Cowboy Motors",
                            SupPhone = "4744058261",
                            SupEmail = "cowboymotor23@domain.ca",
                            SupAddress = "4189 Haaglund Rd",
                            SupCity = "Peachland",
                            SupProvince = "BC",
                            SupPostal = "V0H 1X0"
                        },
                        new Supplier
                        {
                            SupName = "Royal Smashers",
                            SupPhone = "2495679487",
                            SupEmail = "royalsmashers@domain.ca",
                            SupAddress = "894 Poplar Street",
                            SupCity = "Alberton",
                            SupProvince = "PEI",
                            SupPostal = "C0B 1B0"
                        },
                        new Supplier
                        {
                            SupName = "Brandon Malik",
                            SupPhone = "4743331639",
                            SupEmail = "bmalik123@domain.ca",
                            SupAddress = "4129 Silver Springs Blvd",
                            SupCity = "Calgary",
                            SupProvince = "AB",
                            SupPostal = "T3E 0K6"
                        },
                        new Supplier
                        {
                            SupName = "Cameron Guimond",
                            SupPhone = "2043328769",
                            SupEmail = "camerong11@domain.ca",
                            SupAddress = "3487 Yonge Street",
                            SupCity = "Toronto",
                            SupProvince = "ON",
                            SupPostal = "M4W 1J7"
                        },
                        new Supplier
                        {
                            SupName = "Rainbow Ace",
                            SupPhone = "3438554948",
                            SupEmail = "rainbowace@domain.ca",
                            SupAddress = "3791 St Marys Rd",
                            SupCity = "Winnipeg",
                            SupProvince = "MN",
                            SupPostal = "R3C 0C4"
                        },
                        new Supplier
                        {
                            SupName = "Kikkoman",
                            SupPhone = "2898086253",
                            SupEmail = "kikkomanquebec@domain.ca",
                            SupAddress = "251 Saskatchewan Dr",
                            SupCity = "Quebec",
                            SupProvince = "QC",
                            SupPostal = "S4P 3Y2"
                        });
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.GetBaseException().Message);
            }
        }
    }
}
