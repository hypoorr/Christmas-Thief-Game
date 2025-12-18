using UnityEngine;
using TMPro;
using UnityEngine.Events;
public class DoorScript : Interactable
{
    [SerializeField] private GameObject playerObject;
    [SerializeField] private Transform destinationPoint;

    [SerializeField] private ItemBag itemBag;
    [SerializeField] private MoneyManager moneyManager;

    [SerializeField] private UnityEvent OnExit;
    // result screen text
    [SerializeField] private TextMeshProUGUI ItemsStoleText;
    [SerializeField] private TextMeshProUGUI MoneyMadeText;

    protected override void Interact()
    {
        Debug.Log("Interacted with " + gameObject.name);
        CharacterController cc = playerObject.GetComponent<CharacterController>();

        cc.enabled = false;
        // Move the player to the destination
        playerObject.transform.position = destinationPoint.position;

        cc.enabled = true;

        //prompt results screen + reward
        ItemsStoleText.text = "Gifts Stolen: " + (itemBag.CurrentCount).ToString();
        MoneyMadeText.text = "Money made: £" + (itemBag.TotalValue).ToString();
        moneyManager.Money = itemBag.TotalValue;
        OnExit.Invoke();
        Cursor.lockState = CursorLockMode.None;




    }
}