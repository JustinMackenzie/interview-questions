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

            if (lengthB > lengthA)
            {
                return FindMedianSortedArrays(nums2, nums1);
            }

            // Perform binary search on array A.
            int start = 0;
            int end = lengthA;

            while (start <= end)
            {
                int partitionA = (end + start) / 2;
                int partitionB = ((lengthA + lengthB + 1) / 2) - partitionA;

                int maxLeftA = partitionA == 0 ? int.MinValue : nums1[partitionA - 1];
                int minRightA = partitionA == lengthA ? int.MaxValue : nums1[partitionA];

                int maxLeftB = partitionB == 0 ? int.MinValue : nums2[partitionB - 1];
                int minRightB = partitionB == lengthB ? int.MaxValue : nums2[partitionB];

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
