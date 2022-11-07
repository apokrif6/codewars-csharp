//Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)

//    HH = hours, padded to 2 digits, range: 00 - 99
//    MM = minutes, padded to 2 digits, range: 00 - 59
//    SS = seconds, padded to 2 digits, range: 00 - 59

//The maximum time never exceeds 359999 (99:59:59)

//You can find some examples in the test fixtures.


public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
        string hr = formatedDate(seconds / 3600);
        string min = formatedDate(seconds / 60 % 60);
        string sec = formatedDate(seconds % 60);
      
        return hr + ":" + min + ":" + sec;
    }
  
    public static string formatedDate(int date)
    {
      return (date > 9) ? date.ToString() : '0' + date.ToString();  
    }
}
