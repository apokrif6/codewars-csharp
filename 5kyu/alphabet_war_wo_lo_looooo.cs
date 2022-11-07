//Introduction

//There is a war and nobody knows - the alphabet war!
//There are two groups of hostile letters. The tension between left side letters and right side letters was too high and the war began. The letters have discovered a new unit - a priest with Wo lo looooooo power.
//Task

//Write a function that accepts fight string consists of only small letters and return who wins the fight. When the left side wins return Left side wins!, when the right side wins return Right side wins!, in other case return Let's fight again!.

//The left side letters and their power:

// w - 4
// p - 3 
// b - 2
// s - 1
// t - 0 (but it's priest with Wo lo loooooooo power)

//The right side letters and their power:

// m - 4
// q - 3 
// d - 2
// z - 1
// j - 0 (but it's priest with Wo lo loooooooo power)

//The other letters don't have power and are only victims.
//The priest units t and j change the adjacent letters from hostile letters to friendly letters with the same power.

//mtq => wtp
//wjs => mjz

//A letter with adjacent letters j and t is not converted i.e.:

//tmj => tmj
//jzt => jzt

//The priests (j and t) do not convert the other priests ( jt => jt ).
//Example

//alphabetWar("z")         //=>  "z"  => "Right side wins!"
//alphabetWar("tz")        //=>  "ts" => "Left side wins!" 
//alphabetWar("jz")        //=>  "jz" => "Right side wins!" 
//alphabetWar("zt")        //=>  "st" => "Left side wins!" 
//alphabetWar("azt")       //=> "ast" => "Left side wins!"
//alphabetWar("tzj")       //=> "tzj" => "Right side wins!" 

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Kata
{
    private static Dictionary<char, int> pointsSystem = new Dictionary<char, int>(){
          {'w',-4}, 
          {'p',-3},
          {'b',-2},
          {'s',-1},
          {'m',4},
          {'q',3},
          {'d',2},
          {'z',1}};
          
    public static string AlphabetWar(string fight)
    {
        var regex = new Regex(
@"((?<!t)[wpbs]j[wpbs](?!t))|(j[wpbs](?!t))|((?<!t)[wpbs]j)|((?<!j)[mqdz]t[mqdz](?!j))|(t[mqdz](?!j))|((?<!j)[mqdz]t)");
        
        var warriors = regex.Matches(fight)
          .Cast<Match>()
          .Sum(m => m.Value.Sum(c => getPointsByChar(c) * -1) );
          
        var differencePoints = regex.Replace(fight, "")
          .Sum(c => getPointsByChar(c)) + warriors;
        
        if (differencePoints == 0) return "Let's fight again!";
      
        if(differencePoints < 0) return "Left side wins!";
        
      return "Right side wins!";
    }
    
    private static int getPointsByChar(char c) {
        int currentValue;
      
        return pointsSystem.TryGetValue(c, out currentValue) ? currentValue : 0;
    }
}
