using System.Collections.Generic;
using UnityEngine;

public class ItemSpawnManager : MonoBehaviour
{
    [SerializeField] private ItemLocationsSO itemLocations;

    private List<Vector3> availableLocations;
    void Awake()
    {
        ResetSpawnLocations();
    }
    public Vector3 GetUniqueSpawnLocation()
    {
        if (availableLocations.Count == 0)
        {
            Debug.LogWarning("no spawn locations left");
            return Vector3.zero;
        }

        int index = Random.Range(0, availableLocations.Count);
        Vector3 location = availableLocations[index];
        availableLocations.RemoveAt(index);
        return location;
    }
    public void ResetSpawnLocations()
    {
        availableLocations = new List<Vector3>(itemLocations.Locations);
    }
    public int RemainingSpawns => availableLocations.Count;
}
