public class Stack<T>
{
    public T Value { get; set; }
    public List<T> st = new List<T>();
    public void Push(T item)
    {
        st.Add(item);
    }
    public void Pop(T item)
    {
        var cip = st.FindLast(e => e == item-1);
        
    }
}