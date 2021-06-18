using GraphQL.Project.Models;
using System.Collections.Generic;

namespace GraphQL.Project.Interfaces
{
    public interface IReservationService
    {
        IReadOnlyCollection<Reservation> GetAllReservations();
        Reservation AddReservation(Reservation reservation);
    }
}
