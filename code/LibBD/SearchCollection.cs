namespace LibBD
{
    public class SearchCollection
    {
        public string Name { get; set; }
        public CriteriaOperator Operator { get; set; }
        public object Value { get; set; }
        public bool IsVarchar { get; set; }
        public LogicOperator LogicOp { get; set; }


        public SearchCollection(string name, CriteriaOperator CompOp, object value,bool varchar,LogicOperator LogOp) 
        {
            this.Name = name;
            this.Operator = CompOp;
            this.IsVarchar = varchar;
            this.LogicOp = LogOp;

            if (IsVarchar)
                this.Value = $"'{value}'";
            else
                this.Value = value;
        }

        public string ParseOperator(CriteriaOperator op) 
        {
            string res="";
            /* 
        EQUALS
        NOT_EQUALS,
        GREATER_THAN,
        LESS_THAN,
        GREATER_THAN_EQUALS,
        LESS_THAN_EQUALS,
        LIKE
            */
            switch (op)
            {
                case CriteriaOperator.EQUALS:
                    res= "=";
                    break;
                case CriteriaOperator.GREATER_THAN:
                    res = ">";
                    break;
                case CriteriaOperator.GREATER_THAN_EQUALS:
                    res = ">=";
                    break;
                case CriteriaOperator.LESS_THAN:
                    res = "<";
                    break;
                case CriteriaOperator.LESS_THAN_EQUALS:
                    res = "<=";
                    break;
                case CriteriaOperator.LIKE:
                    res = "LIKE";
                    break;
                case CriteriaOperator.NOT_EQUALS:
                    res = "!=";
                    break;


                default:
                    res = "";
                    break;
            }
            return res;
        }

        public string ParseLogicOperator(LogicOperator op)
        {
            string res = "";
            /* 
        AND,
        OR,
        NOTHING
            */
            switch (op)
            {
                case LogicOperator.OR:
                    res = "OR ";
                    break;
                case LogicOperator.AND:
                    res = "AND ";
                    break;
                case LogicOperator.NOTHING:
                    res = "";
                    break;
                
                default:
                    res = "";
                    break;
            }
            return res;
        }

    }
}