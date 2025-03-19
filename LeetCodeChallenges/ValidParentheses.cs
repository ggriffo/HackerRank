namespace LeetCodeChallenges;

internal class ValidParentheses
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (c == ')' && !(stack.Count == 0) && stack.Peek() == '(')
            {
                stack.Pop();
            }
            else if (c == '}' && !(stack.Count == 0) && stack.Peek() == '{')
            {
                stack.Pop();
            }
            else if (c == ']' && !(stack.Count == 0) && stack.Peek() == '[')
            {
                stack.Pop();
            }
            else
            {
                stack.Push(c);
            }
        }

        return stack.Count == 0;
    }
}