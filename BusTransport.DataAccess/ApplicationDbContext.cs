using BusTransport.Model.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BusTransport.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        #region DB SETS
       
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<BusStop> BusStops { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<ReportCategory> ReportCategories { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<SeatsOfBus> SeatsOfBuses { get; set; }
        public DbSet<RouteStop> RouteStopps { get; set; }
        #endregion


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Ticket Table
            modelBuilder.Entity<Ticket>().HasKey(t => t.Ticket_Id);

            modelBuilder.Entity<Ticket>().HasOne(p => p.Passenger)
                                         .WithOne(p => p.Ticket)
                                         .HasForeignKey<Ticket>(p => p.Passenger_Id);
            modelBuilder.Entity<Ticket>().HasOne(p => p.Discount)
                                           .WithOne(p => p.Ticket)
                                           .HasForeignKey<Ticket>(p => p.Discount_Id);

            modelBuilder.Entity<Ticket>().Property(t => t.StartStop).HasMaxLength(50)
                                                                    .IsRequired();

            modelBuilder.Entity<Ticket>().Property(t => t.EndStop).IsRequired()
                                                                  .HasMaxLength(50); ;

            modelBuilder.Entity<Ticket>().Property(t => t.TicketPrice).IsRequired()
                                                                      .HasPrecision(2, 2);

            modelBuilder.Entity<Ticket>().Property(t => t.SeatNumber).IsRequired();

            modelBuilder.Entity<Ticket>().Property(t => t.DepartureDate).IsRequired();

            modelBuilder.Entity<Ticket>().Property(t => t.IsVaild).IsRequired();
            #endregion

            #region Bus Table
            modelBuilder.Entity<Bus>().HasKey(c => c.Bus_Id);

            //SPATIAL
            #endregion

            #region BusStop Table
            modelBuilder.Entity<BusStop>().HasKey(c => c.BusStop_Id);
            #endregion

            #region Course Table
            modelBuilder.Entity<Course>().HasKey(c => c.CourseId);

            #endregion

            #region Driver Table
            modelBuilder.Entity<Driver>().HasKey(c => c.Driver_Id);
            #endregion

            #region Passenger Table
            modelBuilder.Entity<Passenger>().HasKey(p => p.Passenger_Id);

            modelBuilder.Entity<Passenger>().Property(t => t.Name).IsRequired();
            modelBuilder.Entity<Passenger>().Property(t => t.Name).HasMaxLength(30);

            modelBuilder.Entity<Passenger>().Property(t => t.Surname).IsRequired();
            modelBuilder.Entity<Passenger>().Property(t => t.Surname).HasMaxLength(30);

            modelBuilder.Entity<Passenger>().Property(t => t.Age).IsRequired();

            modelBuilder.Entity<Passenger>().Property(t => t.Email).IsRequired();
            modelBuilder.Entity<Passenger>().Property(t => t.Email).HasMaxLength(50);

            modelBuilder.Entity<Passenger>().Property(t => t.Password).IsRequired();
            modelBuilder.Entity<Passenger>().Property(t => t.Password).HasMaxLength(12);

            #endregion

            #region Route Table
            modelBuilder.Entity<Route>().HasKey(c => c.Route_Id);
            #endregion

            #region Report Table
            modelBuilder.Entity<Report>().HasKey(t => t.Report_Id);

            #endregion

            #region ReportCategory Table
            modelBuilder.Entity<ReportCategory>().HasKey(t => t.ReportCategory_Id);


            #endregion

            #region Seat Table
            modelBuilder.Entity<Seat>().HasKey(t => t.Seat_Id);


            #endregion

            #region Discount Table
            modelBuilder.Entity<Discount>().HasKey(t => t.Discount_Id);

            modelBuilder.Entity<Discount>().Property(t => t.DiscountName).IsRequired();
            modelBuilder.Entity<Discount>().Property(t => t.DiscountName).HasMaxLength(25);

            modelBuilder.Entity<Discount>().Property(t => t.DiscountValue).IsRequired();

            #endregion

            #region SeatsOfBus Table
            modelBuilder.Entity<SeatsOfBus>().HasKey(t => t.SeatsOfBus_Id);
            #endregion

            #region RouteStop Table
            modelBuilder.Entity<RouteStop>().HasKey(t => t.RouteStop_Id);
            #endregion

            //--------------------DATA SEED------------------------
            #region data TICKET
            modelBuilder.Entity<Ticket>().HasData(
                new Ticket
                {
                    Ticket_Id = 1,
                    TicketPrice = 0,
                    SeatNumber = 12,
                    IsVaild = true,
                    Passenger_Id = 1,
                    Discount_Id = 1,
                    StartStop = "przystanek 1",
                    EndStop = "przystanek 1",
                    DepartureDate = DateTime.Now
                },
                new Ticket
                {
                    Ticket_Id = 2,
                    TicketPrice = 0,
                    SeatNumber = 12,
                    IsVaild = false,
                    Passenger_Id = 2,
                    Discount_Id = 2,
                    StartStop = "przystanek 1",
                    EndStop = "przystanek 1",
                    DepartureDate = DateTime.Now
                }
            );
            #endregion

            #region data DISCOUNT
            modelBuilder.Entity<Discount>().HasData(
                new Discount
                {
                    Discount_Id = 1,
                    DiscountName = "Bez zniżki",
                    DiscountValue = 1.00f,
                },
                new Discount
                {
                    Discount_Id = 2,
                    DiscountName = "Student 40%",
                    DiscountValue = 0.60f,
                },
                new Discount
                {
                    Discount_Id = 3,
                    DiscountName = "Uczeń 55%",
                    DiscountValue = 0.45f,
                },
                new Discount
                {
                    Discount_Id = 4,
                    DiscountName = "Emeryt 60%",
                    DiscountValue = 0.40f
                },
                new Discount
                {
                    Discount_Id = 5,
                    DiscountName = "Poseł 100%",
                    DiscountValue = 0.0f
                }
                );
            #endregion

            #region data PASSENGER
            modelBuilder.Entity<Passenger>().HasData(
                new Passenger
                {
                    Passenger_Id = 1,
                    Name = "Jan",
                    Surname = "Kowalski",
                    Age = 31,
                    Email = "JanKofalski@gmail.com",
                    Password = "test",
                },
                new Passenger
                {
                    Passenger_Id = 2,
                    Name = "Jan2",
                    Surname = "Kowalski2",
                    Age = 69,
                    Email = "JanKofalski222@gmail.com",
                    Password = "test",
                }
                );
            #endregion

            #region data COURSE
            #endregion

            #region data BUS

            #endregion

            #region data BUSSTOP
            modelBuilder.Entity<BusStop>().HasData(
                new BusStop
                {
                    BusStop_Id = 1,
                    StopName = "Owsianka",
                    BusStopLocationX = 0.0,
                    BusStopLocationY = 0.0
                },
                new BusStop
                {
                    BusStop_Id = 2,
                    StopName = "Rosochatka",
                    BusStopLocationX = 0.0,
                    BusStopLocationY = 0.0
                },
                new BusStop
                {
                    BusStop_Id = 3,
                    StopName = "Samoklęski-Kolonia Pierwsza",
                    BusStopLocationX = 0.0,
                    BusStopLocationY = 0.0
                },
                new BusStop
                {
                    BusStop_Id = 4,
                    StopName = "Rozpłucie Pierwsze",
                    BusStopLocationX = 0.0,
                    BusStopLocationY = 0.0
                },
                new BusStop
                {
                    BusStop_Id = 6,
                    StopName = "Niedźwiada Duża",
                    BusStopLocationX = 0.0,
                    BusStopLocationY = 0.0
                },
                new BusStop
                {
                    BusStop_Id = 7,
                    StopName = "Przeginia Duchowna",
                    BusStopLocationX = 0.0,
                    BusStopLocationY = 0.0
                },
                new BusStop
                {
                    BusStop_Id = 8,
                    StopName = "Swędzieniejewice",
                    BusStopLocationX = 0.0,
                    BusStopLocationY = 0.0
                },
                new BusStop
                {
                    BusStop_Id = 9,
                    StopName = "Jeże",
                    BusStopLocationX = 0.0,
                    BusStopLocationY = 0.0
                },
                new BusStop
                {
                    BusStop_Id = 10,
                    StopName = "Pędziwiatry",
                    BusStopLocationX = 0.0,
                    BusStopLocationY = 0.0
                },
                new BusStop
                {
                    BusStop_Id = 11,
                    StopName = "Stare Pieścirogi",
                    BusStopLocationX = 0.0,
                    BusStopLocationY = 0.0
                },
                new BusStop
                {
                    BusStop_Id = 12,
                    StopName = "Grabce-Towarzystwo",
                    BusStopLocationX = 0.0,
                    BusStopLocationY = 0.0
                },
                new BusStop
                {
                    BusStop_Id = 13,
                    StopName = "Przedmieście Szczebrzeszyńskie",
                    BusStopLocationX = 0.0,
                    BusStopLocationY = 0.0
                },
                new BusStop
                {
                    BusStop_Id = 14,
                    StopName = "Sobienie Kiełczewskie Pierwsze",
                    BusStopLocationX = 0.0,
                    BusStopLocationY = 0.0
                },
                new BusStop
                {
                    BusStop_Id = 15,
                    StopName = "Stare Leśne Bohatery",
                    BusStopLocationX = 0.0,
                    BusStopLocationY = 0.0
                },
                new BusStop
                {
                    BusStop_Id = 16,
                    StopName = "Warszawa",
                    BusStopLocationX = 0.0,
                    BusStopLocationY = 0.0
                },
                new BusStop
                {
                    BusStop_Id = 17,
                    StopName = "Kętrzyn",
                    BusStopLocationX = 0.0,
                    BusStopLocationY = 0.0
                }
                );
            #endregion

        }
    }
}