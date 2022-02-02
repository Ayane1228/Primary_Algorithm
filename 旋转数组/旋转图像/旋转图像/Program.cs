/*
 给定一个 n × n 的二维矩阵 matrix 表示一个图像。请你将图像顺时针旋转 90 度。

你必须在 原地 旋转图像，这意味着你需要直接修改输入的二维矩阵。请不要 使用另一个矩阵来旋转图像。

输入：matrix = [[1,2,3],[4,5,6],[7,8,9]]
输出：[[7,4,1],[8,5,2],[9,6,3]]

输入：matrix = [[5,1,9,11],[2,4,8,10],[13,3,6,7],[15,14,12,16]]
输出：[[15,13,2,5],[14,3,4,1],[12,6,8,9],[16,7,10,11]]
 

提示：
n == matrix.length == matrix[i].length
1 <= n <= 20
-1000 <= matrix[i][j] <= 1000
 

作者：力扣 (LeetCode)
链接：https://leetcode-cn.com/leetbook/read/top-interview-questions-easy/xnhhkv/
来源：力扣（LeetCode）
著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
 */

public class Solution
{
    public void Rotate(int[][] matrix)
    {
        int length = matrix.Length;
        // 上下交换 
        // 只交换一半 length / 2
        // 第 i 个数组 和 第 length - i - 1 个数组交换
        for (int i = 0; i < length / 2; i++)
        {
            int[] temp = matrix[i];
            matrix[i] = matrix[length - 1 - i];
            matrix[length - 1 - i] = temp;
        }
        // 对角线交换 从[0][1]开始到[n][n-1]结束
        // arr[ i ][ j ] => arr[ j ][ i ]
        for (int i = 0; i < length; i++)
        {
            for (int j = i + 1; j < length; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }
    }
}