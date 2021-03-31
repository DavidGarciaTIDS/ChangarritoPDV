namespace LibBD
{
    public class OrderBy
    {

        public string Name { get; set; }
        public Order OrderCriteria { get; set; }


        public OrderBy(string name, Order orderCriteria)
        {
            Name = name;
            OrderCriteria = orderCriteria;
        }
    }
}