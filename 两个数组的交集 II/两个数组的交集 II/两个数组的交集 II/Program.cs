/*
 * 给你两个整数数组 nums1 和 nums2 ，请你以数组形式返回两数组的交集。返回结果中每个元素出现的次数，应与元素在两个数组中都出现的次数一致（如果出现次数不一致，则考虑取较小值）。可以不考虑输出结果的顺序。

示例 1：

输入：nums1 = [1,2,2,1], nums2 = [2,2]
输出：[2,2]

示例 2:

输入：nums1 = [4,9,5], nums2 = [9,4,9,8,4]
输出：[4,9]
 

提示：

1 <= nums1.length, nums2.length <= 1000
0 <= nums1[i], nums2[i] <= 1000
 

进阶：

如果给定的数组已经排好序呢？你将如何优化你的算法？
如果 nums1 的大小比 nums2 小，哪种方法更优？
如果 nums2 的元素存储在磁盘上，内存是有限的，并且你不能一次加载所有的元素到内存中，你该怎么办？

作者：力扣 (LeetCode)
链接：https://leetcode-cn.com/leetbook/read/top-interview-questions-easy/x2y0c2/
来源：力扣（LeetCode）
著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
*/
using System.Collections;
public class Solution
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        Array.Sort(nums1);
        Array.Sort(nums2);

        if (nums1 == null || nums1.Length < 1
         || nums2 == null || nums2.Length < 1)
        {
            return new int[] { };
        }

        List<int> result = new List<int>();
        int i = 0, j = 0;
        while (true)
        {
            if (nums1[i] < nums2[j])
            {
                i++;
            }
            else if (nums1[i] > nums2[j])
            {
                j++;
            }
            else
            {
                result.Add(nums1[i]);
                i++;
                j++;
            }
            if (i == nums1.Length || j == nums2.Length)
            {
                break;
            }
        }
        return result.ToArray();
    }

    /*******************************************************/
    public int[] Intersect2(int[] nums1, int[] nums2)
    {

        //数组1置为小数组，数组2置为大数组
        if (nums1.Length > nums2.Length)
        {
            var temp = new int[0];
            temp = nums1;
            nums1 = nums2;
            nums2 = temp;
        }
        // 将nums1小数组 去重 后放到 字典 dict中 key为数组中的数字 value为数组中的出现次数
        // Dictionary.add(key,value)
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums1.Length; i++)
        {
            if (dict.ContainsKey(nums1[i]))
            {
                //自增对复杂数据结构也有效
                dict[nums1[i]]++;
            }
            else
            {
                dict.Add(nums1[i], 1);
            }
        }
        // 判断小数组中的数在dict中是否存在 找到一次则将value(出现次数)减一
        var list = new List<int>();
        for (int j = 0; j < nums2.Length; j++)
        {
            if (dict.ContainsKey(nums2[j]) && dict[nums2[j]] > 0)
            {
                dict[nums2[j]] -= 1;
                list.Add(nums2[j]);
            }
        }

        return list.ToArray();
    }
}

