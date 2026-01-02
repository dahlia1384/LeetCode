/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
class Solution {

    private Map<Integer, Integer> inIndex;
    private int prePos;

    public TreeNode buildTree(int[] preorder, int[] inorder) {
        inIndex = new HashMap<>();
        for (int i = 0; i < inorder.length; i++) {
            inIndex.put(inorder[i], i);
        }

        prePos = 0;
        return build(preorder, 0, inorder.length - 1);
    }

    private TreeNode build(int[] preorder, int inL, int inR) {
        if (inL > inR) return null;

        int rootVal = preorder[prePos++];
        TreeNode root = new TreeNode(rootVal);

        int mid = inIndex.get(rootVal);

        root.left = build(preorder, inL, mid - 1);
        root.right = build(preorder, mid + 1, inR);

        return root;
    }
}
