 using Microsoft.EntityFrameworkCore;


namespace RazorPageUI.DataContext
{
    
    public class BoardGamesDbContext : DbContext
    {
        public BoardGamesDbContext(DbContextOptions<BoardGamesDbContext> options): base(options) 
        { 
            
         }

        public DbSet<Models.BoardGame> BoardGames {get; set;}
        
    }
}