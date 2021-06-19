using GraphQL.Project.GraphQL.Types;
using GraphQL.Project.Interfaces;
using GraphQL.Types;

namespace GraphQL.Project.GraphQL.Queries
{
    public class ReservationQuery : ObjectGraphType
    {
        private readonly IReservationService reservationService;

        public ReservationQuery(IReservationService reservationService)
        {
            this.reservationService = reservationService;
            GetReservations();
        }

        private void GetReservations() => Field<ListGraphType<ReservationType>>("reservations",
                resolve: context => reservationService.GetAllReservations());
    }
}
