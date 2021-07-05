using System;
using AutoMapper;
using AutoMapper.Configuration;
using EFCoreExample.BAL;
using EFCoreExample.BAL.Models;
using EFCoreExample.BAL.OutputModels;
using FluentAssertions;
using NUnit.Framework;

namespace EFCoreExample.IntegrationTests
{
    public class BooksMapperTests
    {
        private IMapper _mapper;

        public BooksMapperTests()
        {
            var mapperConfigurationExpression = new MapperConfigurationExpression();

            mapperConfigurationExpression.AddMaps(typeof(BookMappingProfile).Assembly);

            var mapperConfiguration = new MapperConfiguration(mapperConfigurationExpression);
            mapperConfiguration.AssertConfigurationIsValid();

            _mapper = new Mapper(mapperConfiguration);
        }

        [Test]
        public void DbBookToBooks_ShouldBeMapped()
        {
            var expected = new Book
            {
                Title = "Test",
                Author = "Best",
                PagesCount = 100
            };

            var actual = _mapper.Map<Book>(new DbBook
            {
                Id = Guid.NewGuid(),
                Title = "Test",
                Author = "Best",
                PagesCount = 100
            });

            actual.Should().BeEquivalentTo(expected);//no Equals!
        }


        [Test]
        public void BookToDbBooks_ShouldBeMapped()
        {
            var expected = new DbBook
            {
                Title = "Test",
                Author = "Best",
                PagesCount = 100
            };

            var actual = _mapper.Map<DbBook>(new Book
            {
                Title = "Test",
                Author = "Best",
                PagesCount = 100
            });

            actual.Title.Should().Be(expected.Title);//no Equals!
            actual.Author.Should().Be(expected.Author);
            actual.PagesCount.Should().Be(expected.PagesCount);
        }
    }
}