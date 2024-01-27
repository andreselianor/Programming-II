namespace DAMLib
{
    public class Tree
    {
        public class Node<T>
        {
            private Node<T> _parent;
            private List<Node<T>> _children;
            public T item;



            public Node<T> Parent
            {
                get
                {
                    return _parent;
                }
                set
                {
                    Node<T> parent = value;
                    SetParent(parent);
                }
            }
            public bool IsRoot => _parent == null;
            public bool IsLeaf => _children == null;
            public bool IsEmpty => item == null;
            public int ChildCount => _children.Count;
            public int Level => GetLevel();
            public Node<T> Root => GetRoot();



            public Node()
            {
                
            }

            public Node(Node<T> parent, List<Node<T>> children)
            {
                _parent = parent;
                _children = children;
            }



            public int GetLevel()
            {
                return _parent.GetLevel() + 1;
            }

            public Node<T> GetRoot()
            {
                if (this.IsRoot)
                    return this;
                return _parent.GetRoot();
            }

            public Node<T> GetChildren(int index)
            {
                if (index < 0 || index > _children.Count)
                    return null;

                return _children[index];
            }

            public void Detach()
            {
                this.Parent._children = null;
                this._parent = null;
            }

            public void AddChildren(Node<T> child)
            {
                if (this._children == null)
                    this._children = new List<Node<T>>();
                this._children.Add(child);
                child._parent = this;
            }
            public void SetParent(Node<T> parent)
            {
                this._parent = parent;
            }
        }
    }
}
