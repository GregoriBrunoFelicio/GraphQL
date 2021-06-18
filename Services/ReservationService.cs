using GraphQL.Project.Data;
using GraphQL.Project.Interfaces;
using GraphQL.Project.Models;
using System.Collections.Generic;
using System.Linq;

namespace GraphQL.Project.Services
{
    public class ReservationService : IReservationService
    {
        private readonly GraphQlDbContext context;

        public ReservationService(GraphQlDbContext context) => this.context = context;

        public IReadOnlyCollection<Reservation> GetAllReservations() => context.Reservations.ToList();

        public Reservation AddReservation(Reservation reservation)
        {
            context.Add(reservation);
            context.SaveChanges();
            return reservation;
        }
    }
}
