namespace DAMLib
{
    public delegate bool DelegateFilter(int number);

    public class Node<T>
    {
        private Node<T> _parent;
        private List<Node<T>> _children *****;
        public T item;


        public bool IsRoot => _parent == null;
        public bool IsLeaf => _children.Count == 0;
        public bool IsEmpty => item == null;
        public bool HasSiblings => _parent._children.Count > 0 *****;
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
            *****
        }

        public Node(Node<T> parent, T content)
        {
            _parent = parent;
            item = content;
            ****
        }

        // Falla al asignar children que aun no existen
        public Node(Node<T> parent, List<Node<T>> children)
        {
            _parent = parent;
            _children = children;
            ********
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

            for(int i = 0; i < _children.Count; i++)
            {
                *****
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
            if (node == null)
                return;            

            //Pregunta
            Node<T> nodeParent = node._parent;
            int index = nodeParent.IndexOf(node);
            nodeParent.RemoveChildAt(index);

            node._parent = null;
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
            for(int i = 0; i < _children.Count; i++)
            {
                if(del(_children[i].Item))
                    listResult.Add(_children[i]);
            }
            return listResult;
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
    }
}
