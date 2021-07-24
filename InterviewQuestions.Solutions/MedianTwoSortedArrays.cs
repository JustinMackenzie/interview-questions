/**
 * Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
 * The overall run time complexity should be O(log (m+n)).
 * 
 * Input: nums1 = [1,3], nums2 = [2]
 * Output: 2.00000
 * Explanation: merged array = [1,2,3] and median is 2.
 * 
 * Input: nums1 = [1,2], nums2 = [3,4]
 * Output: 2.50000
 * Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.
 */
using System;

namespace InterviewQuestions.Solutions
{
    public class MedianTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            // We will refer to nums1 as array A and nums2 as array B.
            int lengthA = nums1.Length;
            int lengthB = nums2.Length;

            // We want array A to be the smaller of the two, so switch them if required.
            if (lengthB < lengthA)
            {
                return FindMedianSortedArrays(nums2, nums1);
            }

            /// The theory behind this solution is as follows:
            /// We will look for a partition in each array such that we can split each array into a left and right side.
            /// The total amount of items on the left should be equal to the number of items on the right. (For odd totals, there will
            /// be 1 extra in the left side)
            /// We put all the left group of A with the left group of B and the right group of A with the right group of B
            /// If all the values in the left group are less than all the values of the right group, then we can find our median
            /// by either taking the max of the left group (if there are an odd total of numbers) or the average of the
            /// max of the left group and the min of the right group (if there are an even total of numbers).
            /// In order to find the partition, we will use a binary search algorithm to allow us to achieve an O(log(min(n, m))
            /// performance, where n is the size of A and m is the size of B.
            
            // Initialize the start and end of our binary search window.
            int start = 0;
            int end = lengthA;

            while (start <= end)
            {
                // Set the partition position for both arrays.
                int partitionA = (end + start) / 2;
                int partitionB = ((lengthA + lengthB + 1) / 2) - partitionA;

                // Get the max value on the left side of A and the min value on the right side of A.
                int maxLeftA = partitionA == 0 ? int.MinValue : nums1[partitionA - 1];
                int minRightA = partitionA == lengthA ? int.MaxValue : nums1[partitionA];

                // Get the max value on the left side of B and the min value on the right side of B.
                int maxLeftB = partitionB == 0 ? int.MinValue : nums2[partitionB - 1];
                int minRightB = partitionB == lengthB ? int.MaxValue : nums2[partitionB];

                // If the max value on the left of A is smaller than the min value of the right of B
                // AND the max value on the left of B is smaller than the min value on the right of A
                // Then all values on the left are smaller than the values on the right.
                if (maxLeftA <= minRightB && maxLeftB <= minRightA)
                {
                    // We have found the correct partition.
                    if ((lengthA + lengthB) % 2 == 0)
                    {
                        return (Math.Max(maxLeftA, maxLeftB) + Math.Min(minRightA, minRightB)) / 2.0;
                    }
                    else
                    {
                        return Math.Max(maxLeftA, maxLeftB);
                    }
                } 
                else if (maxLeftA > minRightB)
                {
                    // The maximum value in A on the left side is too big, so move the partition to the left.
                    end = partitionA - 1;
                }
                else
                {
                    // The minimum value in A on the right side is too small, so move the partition to the right.
                    start = partitionA + 1;
                }
            }

            throw new InvalidOperationException();
        }
    }
}
