using ConditionalBuilderDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace OrderedBuilderDesignPatter.Tests
{
    public class DemonSlayerBuilderTests
    {
        [Fact]
        public void CreateBuilder_Should_Return_DemonSlayerBuilder()
        {
            //Arrange & Act
            var target = DemonSlayerBuilder.CreateBuilder();

            //Assert
            Assert.NotNull(target);
            Assert.True(target.GetType() == typeof(DemonSlayerBuilder));
        }

        [Fact]
        public void DemonSlayer_Should_Have_A_Defined_Level()
        {
            //Arrange
            var builder = DemonSlayerBuilder.CreateBuilder()
                .WithLevel(10);

            //Act
            var target = builder.Build();

            //Assert
            Assert.NotNull(target);
            Assert.Equal(10, target.Level);
        } 
        
        [Fact]
        public void DemonSlayer_Should_Have_A_Defined_Number_Of_Katanas()
        {
            //Arrange
            var builder = DemonSlayerBuilder.CreateBuilder()
                .WithKatanas(2);

            //Act
            var target = builder.Build();

            //Assert
            Assert.NotNull(target);
            Assert.Equal(2, target.Katanas);
        }

        [Fact]
        public void DemonSlayer_Should_Have_A_Defined_Name()
        {
            //Arrange
            var builder = DemonSlayerBuilder.CreateBuilder()
                .WithName("SparcoSlayer");

            //Act
            var target = builder.Build();

            //Assert
            Assert.NotNull(target);
            Assert.Equal("SparcoSlayer", target.Name);
        }

        [Fact]
        public void DemonSlayer_Should_Have_A_Defined_Rank()
        {
            //Arrange
            var builder = DemonSlayerBuilder.CreateBuilder()
                .WithRank(Ranks.Hashira);

            //Act
            var target = builder.Build();

            //Assert
            Assert.NotNull(target);
            Assert.Equal(Ranks.Hashira, target.Rank);
        }

        [Fact]
        public void DemonSlayer_Should_Have_A_Defined_Entries()
        {
            //Arrange
            var builder = DemonSlayerBuilder.CreateBuilder()
                .WithEntries(10, "Riu");

            //Act
            var target = builder.Build();

            //Assert
            Assert.NotNull(target);
            Assert.Equal("Riu", target.Entries[10]);
        }
    }
}
