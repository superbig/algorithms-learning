public class RBTree
{
    private RBTreeNode m_Sentinel;
    private RBTreeNode m_Root;
    public RBTree(RBTreeNode root)
    {
        m_Root = root;
    }

    private void RBLeftRotate(RBTreeNode node)
    {
        RBTreeNode y = node.right;
        node.right = y.left;

        if (y.left != m_Sentinel)
        {
            m_Root = y;
        }
        else if (node == node.parent.left)
        {

        }
    }

    private void RBRightRotate(RBTreeNode node)
    {

    }

    private void RBInsertFixup(RBTreeNode node)
    {

    }

    public void RBInsert(RBTreeNode node)
    {

    }

    public void RBDelete(RBTreeNode node)
    {

    }
}