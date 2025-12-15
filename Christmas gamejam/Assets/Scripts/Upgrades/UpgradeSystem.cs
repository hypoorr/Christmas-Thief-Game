using UnityEngine;
using TMPro;
public class UpgradeSystem : MonoBehaviour
{
    [SerializeField] private MoneyManager moneyManager;
    [SerializeField] private TextMeshProUGUI valueUpgradeText;
    private int valueUpgradePrice = 100;
    public int valueUpgradeLevel = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void UpgradeValue()
    {
        if (moneyManager.Money >= valueUpgradePrice)
        {
            moneyManager.Money = 0-valueUpgradePrice;
            valueUpgradePrice = valueUpgradePrice + (valueUpgradePrice / 2);
            valueUpgradeLevel += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        valueUpgradeText.text = "£" + valueUpgradePrice.ToString();
    }
}
