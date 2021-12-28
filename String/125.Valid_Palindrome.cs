using System.Text.RegularExpressions;

public class Solution {
    public bool IsPalindrome(string s) {
        //remove all non alpha-numeric characters
        Regex rgx = new Regex("[^a-zA-Z0-9]");
        string input = rgx.Replace(s, "");

        //convert to lower case
        input = input.ToLower();

        //reverse the string and compare if they match
        string reversed = new string(input.Reverse().ToArray());

        return input == reversed;
    }
}