namespace DAMLib
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
                _parent.AddChildren(this);
            }
        }
        public bool IsRoot => _parent == null;
        public bool IsLeaf => _children == null;
        public bool IsEmpty => item == null;        
        public int Level => GetLevel();
        public Node<T> Root => GetRoot();
        public int ChildCount
        {
            get
            {
                return _children == null ? 0 : _children.Count;
            }
        }



        public Node()
        {

        }

        public Node(Node<T> parent, List<Node<T>> children)
        {
            _parent = parent;
            _children = children;
        }


        private void SetParent(Node<T> parent)
        {
            if (parent == null)
                return;
            this._parent = parent;
        }

        public int GetLevel()
        {
            if (_parent == null)
                return 0;
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


        public void AddListChildren(List<Node<T>> listNodes)
        {
            if (listNodes == null)
                return;

            for(int i = 0; i < listNodes.Count; i++)
            {
                this.AddChildren(listNodes[i]);
            }
        }

        
        public override string ToString()
        {
            string result = "";

            T itemRoot = GetRoot().item;
            string root = "" + itemRoot;

            result += $"El nodo que contiene {itemRoot} es el nodo Root del Arbol";

            return result;
        }        
    }
}

