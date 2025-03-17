public class RecentCounter {
    private Queue<int> _queue;
    private int counter;

    public RecentCounter() {
        _queue = new Queue<int>();
        counter = 0;
    }
    
    public int Ping(int t) {
        _queue.Enqueue(t);
        counter++;
        var p = _queue.Peek();
        while(p<t-3000 || p>t){
                _queue.Dequeue();
                counter--;
                p = _queue.Peek();
        }
        return counter;
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */
