/*
Author:      Trevor Karl and Rodney Harris
CLID:        C00441253 and C00445623 
Class:       CMPS 358
Assignment:  Project #5
Due Date:    28 November 2022
Description: DbContext creation for acess to the database 
*/
using BlazorServerWDB;
using Microsoft.EntityFrameworkCore;
using p5_C00441253_C00445623;

namespace BlazorServerWDB.Data;

/*
 * DictionaryDbContext : DbContext
 *
 * Creates a session with the database to get and set definitions
 * within the dictionary db
*/
public class DictionaryDbContext : DbContext 
{
    public DictionaryDbContext(
        DbContextOptions<DictionaryDbContext> options) : 
            base(options) { } 

    public DbSet<Dictionary> Dictionaries { get; set; } 
}