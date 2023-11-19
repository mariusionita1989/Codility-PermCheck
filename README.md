# Codility-PermCheck
A non-empty array A consisting of N integers is given.</br>
A permutation is a sequence containing each element from 1 to N once, and only once.</br>
For example, array A such that:</br>
A[0] = 4</br>
A[1] = 1</br>
A[2] = 3</br>
A[3] = 2</br>
is a permutation, but array A such that:</br>
A[0] = 4</br>
A[1] = 1</br>
A[2] = 3</br>
is not a permutation, because value 2 is missing.</br>
The goal is to check whether array A is a permutation.</br>

Write a function:</br>
class Solution { public int solution(int[] A); }</br>
that, given an array A, returns 1 if array A is a permutation and 0 if it is not.

For example, given array A such that:</br>
A[0] = 4</br>
A[1] = 1</br>
A[2] = 3</br>
A[3] = 2</br>
the function should return 1.

Given array A such that:</br>
A[0] = 4</br>
A[1] = 1</br>
A[2] = 3</br>
the function should return 0.

Write an efficient algorithm for the following assumptions:</br>
N is an integer within the range [1..100,000];</br>
each element of array A is an integer within the range [1..1,000,000,000].
