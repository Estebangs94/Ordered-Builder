using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConditionalBuilderDesignPattern
{
    public class DemonSlayerBuilder
    {
        private readonly List<OrderedAction<DemonSlayer>> _builderActions;

        private const string WithNameMethodName = "<WithName>b__0";

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

        public DemonSlayerBuilder WithName(string name, int order)
        {
            _builderActions.Add(new OrderedAction<DemonSlayer>(slayer => slayer.Name = name, order));

            return this;
        }       

        public DemonSlayerBuilder WithRank(Ranks rank, int order)
        {
            _builderActions.Add(new OrderedAction<DemonSlayer>(slayer => slayer.Rank = Ranks.Hashira, order));

            return this;
        }

        public DemonSlayerBuilder WithLevel(int level, int order)
        {
            _builderActions.Add(new OrderedAction<DemonSlayer>(slayer => slayer.Level = 10, order));

            return this;
        }

        public DemonSlayerBuilder WithKatanas(int katanas, int order)
        {
            _builderActions.Add(new OrderedAction<DemonSlayer>(slayer => slayer.Katanas = katanas, order));

            return this;
        }

        public DemonSlayerBuilder WithEntries(int key, string valor, int order)
        {
            _builderActions.Add(new OrderedAction<DemonSlayer>(slayer =>
                slayer.Entries.Add(key, valor), order));

            return this;
        }

    }
}
