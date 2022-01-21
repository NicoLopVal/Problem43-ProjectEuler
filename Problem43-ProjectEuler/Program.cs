
List<string> pangigitals = new();

string zeroTo9Pan = "9876543210";
char[] arrZeroTo9Pan = zeroTo9Pan.ToCharArray();
GetPer(arrZeroTo9Pan);

double totalSum = 0;

//Iterate through the created list of 9 digit pandigitals and checking for the restrictions
foreach(string pandigital in pangigitals)
{
    if (Convert.ToDouble(pandigital.Substring(1, 3)) % 2 == 0 &&
        Convert.ToDouble(pandigital.Substring(2, 3)) % 3 == 0 &&
        Convert.ToDouble(pandigital.Substring(3, 3)) % 5 == 0 &&
        Convert.ToDouble(pandigital.Substring(4, 3)) % 7 == 0 &&
        Convert.ToDouble(pandigital.Substring(5, 3)) % 11 == 0 &&
        Convert.ToDouble(pandigital.Substring(6, 3)) % 13 == 0 &&
        Convert.ToDouble(pandigital.Substring(7, 3)) % 17 == 0)
        totalSum += Convert.ToDouble(pandigital);
}

Console.WriteLine("The sum of all 0 to 9 pandigital numbers with this property is: " + totalSum);


//Code Below is to build all permutations based from zeroTo9Pan var
void Swap(ref char a, ref char b)
{
    if (a == b) return;
    var temp = a;
    a = b;
    b = temp;
}

void GetPer(char[] list)
{
    int x = list.Length - 1;
    GetPermut(list, 0, x);
}

void GetPermut(char[] list, int k, int m)
{
    if (k == m)
    {
        pangigitals.Add(new string(list));
    }
    else
        for (int i = k; i <= m; i++)
        {
            Swap(ref list[k], ref list[i]);
            GetPermut(list, k + 1, m);
            Swap(ref list[k], ref list[i]);
        }
}