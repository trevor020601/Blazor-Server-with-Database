/*
Author:      Trevor Karl and Rodney Harris
CLID:        C00441253 and C00445623 
Class:       CMPS 358
Assignment:  Project #5
Due Date:    28 November 2022
Description: Contains the Dictionary class for defining the database fields
*/

namespace p5_C00441253_C00445623;

/*
 * Dictionary
 *
 * Contains the getter and setter methods for the Id, Word, and
 * Definition for database interactions
*/
public class Dictionary {
    public int Id { get; set; }
    public string Word { get; set; }
    public string Definition { get; set; }
}