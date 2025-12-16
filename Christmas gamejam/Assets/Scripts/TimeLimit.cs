using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
public class TimeLimit : MonoBehaviour
{
    private int timeStart = 20000;
    private int currentTime;
    [SerializeField] private FieldOfView AIVision;
    [SerializeField] private TextMeshProUGUI timerText;
    public void BeginTimer()
    {
        currentTime = timeStart;
        timerText.text = currentTime.ToString() + "s";
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        while (currentTime > 0)
        {
            yield return new WaitForSeconds(1f);
            if (currentTime > 0)
            {
                currentTime--;
                Debug.Log(currentTime);
            }
            timerText.text = currentTime.ToString() + "s";
        }
        if (currentTime == 0)
        {
            AIVision.OnPlayerCatch.Invoke();
        }

        
    void Update()
    {
        timerText.text = currentTime.ToString() + "s";
    }
        
        
    }

}
