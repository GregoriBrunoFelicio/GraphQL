using GraphQL.Types;

namespace GraphQL.Project.GraphQL.Types
{
    public class ReservationInputType : InputObjectGraphType
    {
        public ReservationInputType()
        {
            Field<IntGraphType>("Id");
            Field<StringGraphType>("Name");
            Field<StringGraphType>("Phone");
            Field<IntGraphType>("TotalPeople");
            Field<StringGraphType>("Date");
            Field<StringGraphType>("Email");
            Field<StringGraphType>("Time");
        }
    }
}
