namespace DAMLib
{
    public class Node<T>
    {        
        private Node<T> _parent;
        private List<Node<T>> _children;   
        public T item;

        public delegate bool DelegateFilter(Node<T> node);
        public delegate void DelegateVisit(Node<T> node);

        public bool IsRoot => _parent == null;
        public bool IsLeaf => _children.Count == 0;
        public bool Children => _children.Count == 0;
        public bool IsEmpty => item == null;
        public bool HasSiblings => _parent._children.Count > 0;
        public int Level => GetLevel();
        public Node<T> Root => GetRoot();
        public Node<T> Parent
        {
            get
            {
                return _parent == null ? this : _parent;
            }
        }

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

        public Node(Node<T> parent)
        {
            _parent = parent;
        }

        public Node(Node<T> parent, T content)
        {
            _parent = parent;
            item = content;
        }

        public Node(Node<T> parent, List<Node<T>> children)
        {
            _parent = parent;
            _children = children;
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

        public Node<T> GetChildrenWithIndex(int index)
        {
            if (index < 0 || index > _children.Count)
                return null;

            return _children[index];
        }
        public int IndexOf(Node<T> node)
        {
            if (node == null || _children == null)
                return -1;

            for (int i = 0; i < _children.Count; i++)
            {
                if (_children[i] == node)
                    return i;
            }
            return -1;
        }

        public void RemoveChildAt(int index)
        {
            if (index < 0 || index >= _children.Count)
                return;

            _children[index]._parent = null;
            _children.RemoveAt(index);
        }
        public void Unlink()
        {
            Node<T> nodeParent = _parent;
            int index = nodeParent.IndexOf(this);
            nodeParent.RemoveChildAt(index);

            _parent = null;
        }

        public void AddChildren(Node<T> child)
        {
            if (child == null)
                return;
            if (child == this)
                return;
            if (child == this._parent)
                return;
            if (ContainsChild(child))
                return;

            if (_children == null)
                _children = new List<Node<T>>();

            child.Unlink();

            this._children.Add(child);
            child._parent = this;
        }
        private void SetParent(Node<T> parent)
        {
            if (parent == this)
                return;
            if (parent == null)
                return;
            if (this._parent == parent)
                return;
            this._parent = parent;
        }
        public void AddListChildren(List<Node<T>> listNodes)
        {
            if (listNodes == null)
                return;

            for (int i = 0; i < listNodes.Count; i++)
            {
                this.AddChildren(listNodes[i]);
            }
        }
        public bool ContainsChild(Node<T> child)
        {
            return IndexOf(child) >= 0;
        }
        public List<Node<T>> Filter(DelegateFilter del)
        {
            List<Node<T>> listResult = new List<Node<T>>();
            for (int i = 0; i < _children.Count; i++)
            {
                if (del(_children[i]))
                    listResult.Add(_children[i]);
            }
            return listResult;
        }
        public void Visit(DelegateVisit visitor)
        {
            if (visitor == null || _children == null)
                return;

            visitor(this);
            for (int i = 0; i < _children.Count - 1; i++)
                _children[i].Visit(visitor);
        }
        public bool IsSameLevel(Node<T> node)
        {
            return this.Level == node.Level;
        }
        public override string ToString()
        {
            string result = "";
            T content = item;
            result = $"El contenido del nodo es: {content}";
            return result;
        }

        #region · DOCUMENTACION
        /*                                                                * /
        DOCUMENTACION PARA LA CLASE NODE · COLECCIONES DE DATOS.
        
        Los elementos se ordenan en forma de arbol. 
        Existe un elemento unico llamado 'root'.
        Los demas nodos se ordenan de manera jerarquica en orden descendente.

        (P) bool IsRoot;
        (P) bool IsCount;
        (P) bool Children;
        (P) bool IsEmpty;
        (P) bool HasSiblings;
        (P) int Level;
        (P) Node<T> Root;
        (P) Node<T> Parent;
        (P) int ChildCount;

        |#| Node() {}
        |#| Node(Node<T> parent) {}
        |#| Node(Node<T> parent, T content) {}

        + GetLevel() : int

        + GetRoot() : Node<T>

        + GetChildrenWithIndex(index) : Node<T>

        + IndexOf(Node<T>) : int

        + RemoveChildAt(index) : void

        + Unlink() : void

        + AddChildren(Node<T>) : void

        - SetParent(Node <T>) : void

        + AddListChildren( List<Node<T>>) : void

        + ContainsChild(Node<T>) : bool

        + Filter(Delegate) : List<Node<T>>

        + Visit(Delegate) : void

        + IsSameLevel(Node<T>) : bool

        + override ToString() : string
        */
        #endregion
    }
}