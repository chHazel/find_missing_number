
class TechTest{
    static int Find_Missing_Value(int[] nArray){
        // find the n
        int n = nArray.Length + 1;

        // find the expected sum, use long data type to avoid large array
        long expectedSum = (long) n * (n-1) / 2;
        long sum = 0;

        // calculate the actual sum
        foreach(int num in nArray){
            sum += num;
        }

        return (int)(expectedSum - sum);
    }

    static void Main(){
        int[] nArray = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
        int missingValue = Find_Missing_Value(nArray);

        Console.WriteLine($"Missing value: {missingValue}");
    }
}