int[] NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 35);
    return array;
}

int[] array = new int[12];

NewArray(array);
int First = array[0] + array[4] + array[8] / 3;
int Second = array[1] + array[5] + array[9] / 3;
int Third = array[2] + array[6] + array[10] / 3;
int Fourth = array[3] + array[7]+ array[11] / 3;
string First1 = Convert.ToString(First);
string Second1 = Convert.ToString(Second);
string Third1 = Convert.ToString(Third);
string Fourth1 = Convert.ToString(Fourth);
System.Console.WriteLine("(" + string.Join(", ", array) + ")");
System.Console.WriteLine(First1 + " " + Second1 + " " + Third1 + " " + Fourth1);