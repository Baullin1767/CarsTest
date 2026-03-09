using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LINQTestBeh : MonoBehaviour
{
    private List<Item> _items = new List<Item>();
    
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            _items.Add(new Item {Id = i, IsUnique = i % 2 == 0});
        }

        List<Item> uniqueItems = _items.Where(item => item.IsUnique).ToList();
        Debug.Log(uniqueItems.Count);
        
        List<Item> idLess5 = _items.Where(i => i.Id < 5).ToList();
        Debug.Log(idLess5.Count);


        List<int> idsItems = _items.Select(i => i.Id).ToList();

        foreach (var i in idsItems)
        {
            Debug.Log(i);
        }


        if (_items.All(item => item.IsUnique))
        {
            Debug.Log("All items are unique");
        }
        
        if (uniqueItems.All(item => item.IsUnique))
        {
            Debug.Log("All items are unique");
        }
        
        
        
        if (_items.Any(item => item.IsUnique))
        {
            Debug.Log("One of more items are unique");
        }
        
        if (uniqueItems.Any(item => item.IsUnique))
        {
            Debug.Log("One of more items are unique");
        }
        
        
        Dictionary<int, bool> map = _items.ToDictionary(item => item.Id, item => item.IsUnique);
        
        var v = _items.OrderBy(item => item.Id).ToList();
    }

    class Item
    {
        public bool IsUnique;
        public int Id;
        public string Title;
    }
}
