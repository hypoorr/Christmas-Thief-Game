using UnityEngine;
using TMPro;
public class ItemBag : MonoBehaviour
{
    private int itemLimit = 8;
    private int currentCount = 0;
    [SerializeField] private TextMeshProUGUI ItemCountText;

    public int ItemLimit{
        get {
            return itemLimit;
        }
    }

    public int CurrentCount{
        get {
            return currentCount;
        }
    }

    public void NewItem()
    {
        currentCount += 1;
    }

    void Update()
    {
        ItemCountText.text = currentCount.ToString() + "/" + itemLimit.ToString();
    }
}
