using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using E_Apartments.Models;
using System.Reflection.Emit;
using System.Windows.Controls;
//using Microsoft.EntityFrameworkCore;


namespace E_Apartments.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<CustomerSave> CustomerSaves { get; set; }
        public DbSet<Dependent> Dependents { get; set; }
        public DbSet<Leasing> Leasings { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Parking> Parkings { get; set; }
        public DbSet<AdditionalParking> AdditionalParkings { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<LeaseExtendRequest> LeaseExtendRequest { get; set; }
        public DbSet<AptApplication> AptApplication { get; set; }
    }

}
