using Microsoft.EntityFrameworkCore;
using IJMmachines.Data;

namespace IJMmachines.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new IJMmachinesContext(
                serviceProvider.GetRequiredService<DbContextOptions<IJMmachinesContext>>()))
            {
                if (context == null || context.Machine == null)
                {
                    throw new ArgumentNullException("Null IJMmachinesContext");
                }

                // Look for any machines
                if (context.Machine.Any())
                {
                    return;    // DB has been seeded

                }
                context.Machine.AddRange(
                    new Machine
                    {
                        Date = DateTime.Parse("2020-1-25"),
                        Manufacturer = "Cincinatti Milacron",
                        Tonnage = 250,
                        MachineNumberOfDefectsDamaged = 5,
                        ProcessingDefects = 10,
                        MachineCost = 300000,
                        Description = "Small"
                    },

                    new Machine
                    {
                        Date = DateTime.Parse("2022-3-17"),
                        Manufacturer = "Van Dorn Demag",
                        Tonnage = 300,
                        MachineNumberOfDefectsDamaged = 10,
                        ProcessingDefects = 15,
                        MachineCost = 500000,
                        Description = "Smaller"
                    },

                    new Machine
                    {
                        Date = DateTime.Parse("2024-4-24"),
                        Manufacturer = "Engel",
                        Tonnage = 1000,
                        MachineNumberOfDefectsDamaged = 10,
                        ProcessingDefects = 15,
                        MachineCost = 1000000,
                        Description = "Medium"
                        
                    },

                    new Machine
                    {
                        Date = DateTime.Parse("2024-3-17"),
                        Manufacturer = "Battenfeld",
                        Tonnage = 2500,
                        MachineNumberOfDefectsDamaged = 1,
                        ProcessingDefects = 1,
                        MachineCost = 2000000,
                        Description = "Large"
                    },

                    new Machine
                    {
                        Date = DateTime.Parse("2024-1-10"),
                        Manufacturer = "Kraus Moffeit",
                        Tonnage = 1000,
                        MachineNumberOfDefectsDamaged = 2,
                        ProcessingDefects = 5,
                        MachineCost = 1000000,
                        Description = "Medium 2"
                        
                    }

                    );

                context.SaveChanges();

            }
            
            }

        }
    }
