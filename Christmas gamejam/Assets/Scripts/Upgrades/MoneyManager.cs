using UnityEngine;
using TMPro;
public class MoneyManager : MonoBehaviour
{

    private int money = 1000000;
    [SerializeField] private TextMeshProUGUI moneyText;
    public int Money{
        get{
            return money;
        }

        set{
            money += value;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = "£" + Money.ToString();
    }
}
