using UnityEngine;
using TMPro;
public class ItemBag : MonoBehaviour
{
    private int itemLimit = 4;
    private int currentCount = 0;
    private int totalValue;
    [SerializeField] private TextMeshProUGUI ItemCountText;
    [SerializeField] private TextMeshProUGUI TotalValueText;

    public int ItemLimit{
        get {
            return itemLimit;
        }
    }

    public int CurrentCount{
        get {
            return currentCount;
        }
        set{
            currentCount = value;
        }
    }

    public int TotalValue{
        get{
            return totalValue;
        }
        set{
            totalValue = value;
        }
    }

    public void NewItem(int cost)
    {
        currentCount += 1;
        totalValue += cost;

    }

    void Update()
    {
        ItemCountText.text = currentCount.ToString() + "/" + itemLimit.ToString();
        TotalValueText.text = "£" + totalValue.ToString();

    }
}
