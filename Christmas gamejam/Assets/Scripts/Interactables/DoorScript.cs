using UnityEngine;
 
public class DoorScript : Interactable
{
    [SerializeField] private GameObject playerObject;
    [SerializeField] private Transform destinationPoint;
 
    protected override void Interact()
    {
        Debug.Log("Interacted with " + gameObject.name);
        // Move the player to the destination
        playerObject.transform.position = destinationPoint.position;
    }
}