using System.Collections.Generic;
namespace Algorithms_and_data_structures
{
    public class TreeNode<T>
    {
        public T Data { get; set; }
        protected List<TreeNode<T>> Children { get; set; }
    }
}
