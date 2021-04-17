using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalBuilderDesignPattern
{
    public class OrderedAction<T>
    {
        public Action<T> Action { get; set; }
        public int Order { get; set; }

        public OrderedAction(Action<T> action, int order)
        {
            Action = action;
            Order = order;
        }
    }

}
