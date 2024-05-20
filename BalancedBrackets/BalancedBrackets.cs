﻿using System;

namespace BalancedBracketsNS
{
    public class BalancedBrackets
    {
        /**
         * The function BalancedBrackets should return true if and only if
         * the input string has a set of "balanced" brackets.
         *
         * That is, whether it consists entirely of pairs of opening/closing
         * brackets (in that order), none of which mis-nest. We consider a bracket
         * to be square-brackets: [ or ].
         *
         * The string may contain non-bracket characters as well.
         *
         * These strings have balanced brackets:
         *  "[LaunchCode]", "Launch[Code]", "[]LaunchCode", "", "[]"
         *
         * While these do not:
         *   "[LaunchCode", "Launch]Code[", "[", "]["
         *
         * parameter str - to be validated
         * returns true if balanced, false otherwise
        */
        public static bool HasBalancedBrackets(string str)
        {
            
            int brackets = 0;
            foreach (char ch in str.ToCharArray())
            {
                
                if (!str.Contains('['))
                {
                    return false;
                }
                else if (!str.Contains(']'))
                {
                    return false;
                }
                else if (ch == '[')
                {
                    brackets++;
                }
                else if (ch == ']')
                {
                    if (brackets < 1)
                    {
                        return false;
                    }
                    brackets--;
                }
                
            }
            
            return brackets == 0;
        }
    }
}

