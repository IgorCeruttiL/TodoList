using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Todo.Models.Data
{
	public class AppDbContext : DbContext
	{
		public DbSet<TodoModel> Todos { get; set; }
		
		protected override void OnConfiguring(DbContextOptionsBuilder options) 
			=> options.UseSqlite("DataSource=app.db;Cache=Shared");
	}
}