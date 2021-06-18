using GraphQL.Project.Models;
using GraphQL.Types;

namespace GraphQL.Project.GraphQL.Types
{
    public sealed class ReservationType : ObjectGraphType<Reservation>
    {
        public ReservationType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Phone);
            Field(x => x.TotalPeople);
            Field(x => x.Email);
            Field(x => x.Date);
            Field(x => x.Time);
        }
    }
}
