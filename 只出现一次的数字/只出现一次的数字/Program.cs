/*
给定一个非空整数数组，除了某个元素只出现一次以外，其余每个元素均出现两次。找出那个只出现了一次的元素。

说明：

你的算法应该具有线性时间复杂度。 你可以不使用额外空间来实现吗？

示例 1:

输入: [2,2,1]
输出: 1
示例 2:

输入: [4,1,2,1,2]
输出: 4

------------------------------------------

异或 ^
相同数异或得0，不同数异或得1。即任何数和零异或可以得到其本身。

交换律：a ^ b ^ c <=> a ^ c ^ b
任何数于0异或为任何数 0 ^ n => n
相同的数异或为0: n ^ n => 0

　2 ^ 3 ^ 2 ^ 4 ^ 4等价于 2 ^ 2 ^ 4 ^ 4 ^ 3 => 0 ^ 0 ^3 => 3
 */
int[] nums = { 1, 2, 2 };
 int SingleNumber(int[] nums)
{
    int sum = 0;
    for (int i = 0; i < nums.Length; i++) {
        sum ^= nums[i];
    }
    return sum;
}
Console.WriteLine(SingleNumber(nums));