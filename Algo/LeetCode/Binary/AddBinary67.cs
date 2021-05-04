using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algo.LeetCode.Binary
{
    class AddBinary67
    {
        public string AddBinary(string a, string b)
        {

            int i = a.Length - 1;
            int j = b.Length - 1;
            int carry = 0;
            StringBuilder builder = new StringBuilder();
            int first = 0;
            int second = 0;

            while (i >= 0 || j >= 0 || carry == 1)
            {

                if (i >= 0)
                {
                    first = a[i] - '0';
                }
                else
                {
                    first = 0;
                }

                if (j >= 0)
                {
                    second = b[j] - '0';
                }
                else
                {
                    second = 0;
                }

                int sum = first + second + carry;

                if (sum >= 2)
                {
                    sum = sum % 2;
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }

                builder.Append(sum);
                j--;
                i--;
            }

            return new string(builder.ToString().Reverse().ToArray());
        }
    }
}
