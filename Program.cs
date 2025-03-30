
class TechTest{
    static int FindMissingNumber(int[] nArray){
        // find the n
        int n = nArray.Length + 1;

        // find the expected sum, use long to prevent integer overflow when handling large array sizes
        long expectedSum = (long) n * (n - 1) / 2;
        long sum = 0;

        // calculate the actual sum
        foreach(int num in nArray){
            sum += num;
        }

        return (int)(expectedSum - sum);
    }

    static void Main(){
        int[] nArray = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
        int missingNumber = FindMissingNumber(nArray);

        Console.WriteLine($"Missing number: {missingNumber}");
    }
}