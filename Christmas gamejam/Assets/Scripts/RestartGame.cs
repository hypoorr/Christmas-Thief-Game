using UnityEngine;

public class RestartGame : MonoBehaviour
{
    [SerializeField] private ItemBag itemBag;
    [SerializeField] private TimeLimit timerScript;
    [SerializeField] private GameObject playerObject;
    [SerializeField] private GameObject enemyObject;
    [SerializeField] private GameObject enemyObject2;


    public void Reset()
    {
        //reset item bag
        itemBag.CurrentCount = 0;
        itemBag.TotalValue = 0;

        //reset player position
        CharacterController cc = playerObject.GetComponent<CharacterController>();
        cc.enabled = false;
        playerObject.transform.position = new Vector3(-4f, 1.2f, -13.36f);
        cc.enabled = true;

        //reset enemies position
        enemyObject.transform.position = new Vector3(1.48f, 1.36f, -19.11f);
        enemyObject2.transform.position = new Vector3(1.48f, 6.92f, -19.11f);

    }
    

    // reset item bag
    // reset player position
    // reset time limit
    // reset AI position
    // reset gifts

}
