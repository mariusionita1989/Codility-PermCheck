using System.Runtime.CompilerServices;

namespace Codility_PermCheck
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 1;
        public const int RANGE_HIGHEST_VALUE = 100000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int[] A)
        {
            Array.Sort(A); // Sort the array to check for consecutive elements
            int N = A.Length;

            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE) 
            {
                if (N == 0 || A[0] != 1 || A[N - 1] != N)
                    return 0; // If the first element is not 1 or the last element is not N, it's not a permutation

                for (int i = 0; i < N - 1; i++)
                {
                    if (A[i + 1] - A[i] != 1)
                        return 0; // If the difference between consecutive elements is not 1, it's not a permutation
                }

                return 1; // If all conditions are met, it's a permutation
            }

            return -1;
        }
    }
}
