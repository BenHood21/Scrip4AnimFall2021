using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

[CreateAssetMenu]

    public class CollectionSO : ScriptableObject
    {
        public List<CollectableSO> collection;
    public void Collect(CollectableSO obj)
    {
        collection.Add(obj);
        obj.collected = true;
    }
}
