using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int LongestValidParentheses(string s)
    {
        var stack = new Stack<int>();
        stack.Push(-1);

        var max = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
                stack.Push(i);

            else
            {
                if (stack.Count > 0)
                    stack.Pop();

                if (stack.Count == 0)
                    stack.Push(i);
                else
                    max = new List<int> { max, i - stack.Peek() }.Max();
            }
        }

        return max;
    }
}
