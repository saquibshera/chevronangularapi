using System;
using chevronapi.Models;
using Microsoft.EntityFrameworkCore;

namespace chevronapi.Services
{
	public class DataContext:DbContext
	{
		public DataContext(DbContextOptions<DataContext> options):base(options)
		{

		}

		public DbSet<Person> mytable { get; set; }
	}
}

