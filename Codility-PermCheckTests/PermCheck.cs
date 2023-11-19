using Codility_PermCheck;

namespace Codility_PermCheckTests
{
    public class SolutionTests
    {
        [Fact]
        public void Solution_Permutation_Returns_1()
        {
            // Arrange
            var solution = new Solution();
            int[] A = { 4, 1, 3, 2 };

            // Act
            int result = solution.solution(A);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Solution_NotPermutation_Returns_0()
        {
            // Arrange
            var solution = new Solution();
            int[] A = { 4, 1, 3 };

            // Act
            int result = solution.solution(A);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Solution_EmptyArray_Returns_Minus1()
        {
            // Arrange
            var solution = new Solution();
            int[] A = { };

            // Act
            int result = solution.solution(A);

            // Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Solution_OutOfRange_Returns_Minus1()
        {
            // Arrange
            var solution = new Solution();
            int[] A = new int[100001]; // More elements than the maximum allowed

            // Act
            int result = solution.solution(A);

            // Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Solution_SingleElementArray_Returns_1()
        {
            // Arrange
            var solution = new Solution();
            int[] A = { 1 };

            // Act
            int result = solution.solution(A);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Solution_LargestPermutation_Returns_1()
        {
            // Arrange
            var solution = new Solution();
            int[] A = new int[100000];
            for (int i = 0; i < 100000; i++)
                A[i] = i + 1;
            
            // Act
            int result = solution.solution(A);

            // Assert
            Assert.Equal(1, result);
        }
    }
}