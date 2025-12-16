using UnityEngine;

public class ItemScript : Interactable
{
    [SerializeField] private ItemLocationsSO ItemSpawns;
    [SerializeField] private ItemBag ItemBag;
    [SerializeField] private UpgradeSystem UpgradeSystem;
    GameObject parentObject;
    private int itemValue;


    protected override void Interact()
    {
        itemValue = Random.Range(10,500) * UpgradeSystem.valueUpgradeLevel;
        Debug.Log("Interacted with " + gameObject.name);
        
        if (!(ItemBag.CurrentCount >= ItemBag.ItemLimit))
        {
            Debug.Log("Item is worth £" + itemValue);
            ItemBag.NewItem(itemValue);
            parentObject.SetActive(false);         
        }
        else
        {
            Debug.Log("Bag limit reached");
        }

    }

    void Start()
    {
        // Check if this GameObject has a parent
        if (transform.parent != null)
        {
            GameObject parentObject = transform.parent.gameObject;
            parentObject.SetActive(false);
            Debug.Log("Parent GameObject: " + parentObject.name);
        }
        else
        {
            Debug.Log("This GameObject has no parent.");
        }
        transform.position = ItemSpawns.Locations[Random.Range(0, 5)];
    }
        
        
    
}
