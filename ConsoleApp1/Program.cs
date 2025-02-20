﻿using System;

/* UML Diagram

DiceGame            
 - dice1: Dice                
 - dice2: Dice                
 - rounds: int                
 - dice1Wins: int             
 - dice2Wins: int             

 + PlayGame(): void           
 + GetWinner(): string        


Dice                

 - topSide: int               

 + Roll(): int                
 + GetTopSide(): int          

*/

class Dice                                              //implementing my class 
{
    private int topSide;                                //topSide keeping it in private 
    private static Random random = new Random();        //creating the random 


    public int Roll()                                   //creating my public
    {
        topSide = random.Next(1, 6);                    // keeping my sides to only 6
        return topSide;
    }

}