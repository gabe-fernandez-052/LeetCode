namespace LeetCode.Challenges.Medium
{
    /// <summary>
    /// You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).
    /// Find two lines that together with the x-axis form a container, such that the container contains the most water.
    /// Return the maximum amount of water a container can store.
    /// Notice that you may not slant the container.
    /// </summary>
    public class ContainerWithMostWater : ILeetCode
    {
        public int Run(int[] height)
        {
            var leftPointer = 0;
            var rightPointer = height.Length - 1;
            var containerWidth = rightPointer - leftPointer;
            var containerArea = 0;

            while (leftPointer < rightPointer)
            {
                var containerHeight = Math.Min(height[leftPointer], height[rightPointer]);
                containerArea = Math.Max(containerArea, containerHeight * containerWidth);

                if (height[leftPointer] < height[rightPointer])
                {
                    leftPointer++;
                }
                else
                {
                    rightPointer--;
                }

                containerWidth--;
            }

            return containerArea;
        }
    }
}