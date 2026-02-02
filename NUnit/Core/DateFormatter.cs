/*Testing Date Formatter
Problem:
Create a DateFormatter class with:
● FormatDate(string inputDate): Converts yyyy-MM-dd format to
dd-MM-yyyy.
Write unit test cases for valid and invalid dates.*/


public class DateFormatter
{
    public string FormatDate(string inputDate)
    {
        string[] parts = inputDate.Split('-');
        if (parts.Length != 3)
            return "Invalid";

        string year = parts[0];
        string month = parts[1];
        string day = parts[2];

        return day + "-" + month + "-" + year;
    }
}
