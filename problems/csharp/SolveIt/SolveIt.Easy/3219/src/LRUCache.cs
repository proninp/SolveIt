namespace SolveIt.Easy._3219;

public class LRUCache
{

    private readonly Dictionary<int, LinkedListNode<(int key, int value)>> _map;
    private readonly LinkedList<(int key, int value)> _cache;
    private readonly int _limit;
    
    public LRUCache(int capacity) {
        _limit = capacity;
        _map = new(capacity);
        _cache = new();
    }
    
    public int Get(int key)
    {
        if (!_map.TryGetValue(key, out var node))
            return -1;
        
        _cache.Remove(node);
        _cache.AddFirst(node);
        
        return node.Value.value;
    }
    
    public void Put(int key, int value) {
        if (_map.TryGetValue(key, out var node))
        {
            _cache.Remove(node);
        }
        else if (_cache.Count == _limit)
        {
            var lru = _cache.Last!;
            _cache.Remove(lru);
            _map.Remove(lru.Value.key);
        }

        var newNode = new LinkedListNode<(int key, int value)>((key, value));
        _cache.AddFirst(newNode);
        _map[key] = newNode;
    }
}