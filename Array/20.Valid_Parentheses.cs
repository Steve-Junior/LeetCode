using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();
        var dictionary = new Dictionary<char, char>();

        dictionary.Add(')', '(');
        dictionary.Add(']', '[');
        dictionary.Add('}', '{');

        foreach (var c in s)
        {
            if (new char[] { '(', '{', '[' }.Any(x => x == c))
            {
                stack.Push(c);
                continue;
            }

            if (stack.Count > 0 && stack.Peek() == dictionary[c])
            {
                stack.Pop();
                continue;
            }

            return false;
        }

        return stack.Count == 0;
    }
}