public class Solution {
    public int[] TwoSum(int[] numbers, int target) 
    {
        int low = 0;
        int high = numbers.Length -1;
        while(numbers[low] + numbers[high] != target)
        {
            // if the sum is too low, you need bigger numbers
            // else you need smaller numbers, lower the max
            if(numbers[low] + numbers[high] < target)
            {
                low++;
            }
            else
            {
                high--;
            }
        }
        return new int[]{low + 1, high + 1};
    }
}
