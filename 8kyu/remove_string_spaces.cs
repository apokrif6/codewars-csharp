//Simple, remove the spaces from the string, then return the resultant string.

namespace Solution 
{
  public static class SpacesRemover
  {
    public static string NoSpace(string input)
    {
        return input.Replace(" ", string.Empty);
    }  
  }
}
