//The first input array is the key to the correct answers to an exam, like ["a", "a", "b", "d"]. The second one contains a student's submitted answers.

//The two arrays are not empty and are the same length. Return the score for this array of answers, giving +4 for each correct answer, -1 for each incorrect answer, and +0 for each blank answer, represented as an empty string (in C the space character is used).

//If the score < 0, return 0.

using System;

public static class Kata
{
    public static int CheckExam(string[] arr1, string[] arr2)
    {
      int score = 0;
      
      for (int i = 0; i < arr2.Length; i++) {
        if (arr1[i] == arr2[i]) {
          score += 4;
        } else if (arr2[i] == "") {
          
        } else if (arr1[i] != arr2[i]) {
          score -= 1;
        }
      }
      
      if (score < 0)
        return 0;
      
      return score;
    }
}
