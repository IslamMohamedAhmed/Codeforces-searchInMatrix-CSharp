int[,] arr1 = new int[101, 101];
int N, M, count = 0;
string nm = Console.ReadLine();
var arr2 = nm.Split(" ");
N = Convert.ToInt32(arr2[0]);
M = Convert.ToInt32(arr2[1]);
for (int i = 0; i < N; i++)
{
    string eles = Console.ReadLine();
    var arr3 = eles.Split(" ");
    for (int j = 0; j < M; j++)
    {
        arr1[i, j] = Convert.ToInt32(arr3[j]);
    }
}
int x = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        if (x == arr1[i, j])
        {
            count++;
            break;
        }
    }
}
if (count > 0)
{
    Console.WriteLine("will not take number");
}
else
{
    Console.WriteLine("will take number");
}
