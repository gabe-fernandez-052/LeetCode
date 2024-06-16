using LeetCode;

var obj = new TwoSum();

var nums = new int[10] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 7 };
var target = 11;

obj.BruteForce(nums, target);
obj.TwoPass(nums, target);
obj.OnePass(nums, target);

Console.ReadLine();
