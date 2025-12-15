using UnityEngine;

public class ItemScript : Interactable
{
    [SerializeField] private ItemLocationsSO ItemSpawns;
    [SerializeField] private ItemBag ItemBag;
    [SerializeField] private UpgradeSystem UpgradeSystem;
    private int itemValue;


    protected override void Interact()
    {
        itemValue = Random.Range(10,500) * UpgradeSystem.valueUpgradeLevel;
        Debug.Log("Interacted with " + gameObject.name);
        
        if (!(ItemBag.CurrentCount >= ItemBag.ItemLimit))
        {
            Debug.Log("Item is worth £" + itemValue);
            ItemBag.NewItem(itemValue);
            Destroy(gameObject);            
        }
        else
        {
            Debug.Log("Bag limit reached");
        }

    }

    void Start()
    {
        transform.position = ItemSpawns.Locations[Random.Range(0, 5)];
        
    }
}
