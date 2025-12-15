using UnityEngine;

public class DoorScript : Interactable
{
    [SerializeField] private GameObject playerObject;
    [SerializeField] private Transform destinationPoint;
    [SerializeField] private ItemBag itemBag;
    [SerializeField] private MoneyManager moneyManager;
    protected override void Interact()
    {
        Debug.Log("Interacted with " + gameObject.name);
        CharacterController cc = playerObject.GetComponent<CharacterController>();

        cc.enabled = false;
        // Move the player to the destination
        playerObject.transform.position = destinationPoint.position;

        cc.enabled = true;

        //sell the items in the bag

    }
}