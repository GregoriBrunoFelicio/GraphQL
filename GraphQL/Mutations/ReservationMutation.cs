using GraphQL.Project.GraphQL.Types;
using GraphQL.Project.Interfaces;
using GraphQL.Project.Models;
using GraphQL.Types;

namespace GraphQL.Project.GraphQL.Mutations
{
    public class ReservationMutation : ObjectGraphType
    {
        private readonly IReservationService reservationService;

        public ReservationMutation(IReservationService reservationService)
        {
            this.reservationService = reservationService;
            CreateReservation();
        }

        private void CreateReservation() =>
            Field<ReservationInputType>("createReservation",
                arguments: new QueryArguments(
                    new QueryArgument<ReservationInputType> { Name = "Reservation" }
                ), resolve:
                context =>
                    reservationService.AddReservation(context.GetArgument<Reservation>("Reservation")));
    }
}
