Console.Clear();

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 15, b1 = 21, c1 = 39, a2 = 128, b2 = 233, c2 = 33, a3 = 13, b3 = 23, c3 = 33;
int[] array = { 11, 21, 31, 41, 15, 61, 17, 18, 19 };


int maxFin = Max(Max(array[0], b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine($"Max = {maxFin}");