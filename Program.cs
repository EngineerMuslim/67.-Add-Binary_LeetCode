using System.Text;

class program
{
    static string AddBinary(string a, string b)
    {
        int i=a.Length - 1, j = b.Length - 1, carry = 0;
        StringBuilder result = new StringBuilder();
        while(i >= 0 || j >= 0 || carry > 0)
        {
            int sum = carry;
            if (i >= 0) sum += a[i--] - '0';
            if (j >= 0) sum += b[j--] - '0';
            result.Append(sum % 2);
            carry = sum / 2;
        }
        char[] resultArray = result.ToString().ToCharArray();
        Array.Reverse(resultArray);
        return new string(resultArray);
    }
    static void Main(string[] args)
    {
        string a = "1010";
        string b = "1011";

        string result = AddBinary(a, b);

        Console.WriteLine(result);
    }
}