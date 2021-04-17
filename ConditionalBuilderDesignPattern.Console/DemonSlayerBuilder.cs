using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConditionalBuilderDesignPattern
{
    public class DemonSlayerBuilder
    {
        private readonly List<OrderedAction<DemonSlayer>> _builderActions;

        private DemonSlayerBuilder()
        {
            _builderActions = new List<OrderedAction<DemonSlayer>>();
        }

        public static DemonSlayerBuilder CreateBuilder()
            => new DemonSlayerBuilder();

        public DemonSlayer Build()
        {
            var demonSlayer = new DemonSlayer();

            var orderedActions = _builderActions.OrderBy(e => e.Order).ToList();

            orderedActions.ForEach(e => e.Action(demonSlayer));

            return demonSlayer;
        }

        public DemonSlayerBuilder WithName(string name)
        {
            _builderActions.Add(new OrderedAction<DemonSlayer>(slayer => 
                slayer.Name = name, GetOrderFromEnum(ExecutionOrder.WithName)));

            return this;
        }       

        public DemonSlayerBuilder WithRank(Ranks rank)
        {
            _builderActions.Add(new OrderedAction<DemonSlayer>(slayer => 
                slayer.Rank = rank, GetOrderFromEnum(ExecutionOrder.WithRank)));

            return this;
        }

        public DemonSlayerBuilder WithLevel(int level)
        {
            _builderActions.Add(new OrderedAction<DemonSlayer>(slayer => 
                slayer.Level = level, GetOrderFromEnum(ExecutionOrder.WithLevel)));

            return this;
        }

        public DemonSlayerBuilder WithKatanas(int katanas)
        {
            _builderActions.Add(new OrderedAction<DemonSlayer>(slayer => 
                slayer.Katanas = katanas, GetOrderFromEnum(ExecutionOrder.WithKatanas)));

            return this;
        }

        public DemonSlayerBuilder WithEntries(int key, string valor)
        {
            _builderActions.Add(new OrderedAction<DemonSlayer>(slayer =>
                slayer.Entries.Add(key, valor), GetOrderFromEnum(ExecutionOrder.WithEntries)));

            return this;
        }

        private int GetOrderFromEnum(ExecutionOrder order)
            => (int)order;

    }
}
