using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class TimeLimit : MonoBehaviour
{
    private int timeStart = 20;
    private int currentTime;
    [SerializeField] private FieldOfView AIVision;
    public void BeginTimer()
    {
        currentTime = timeStart;
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
        }
        if (currentTime == 0)
        {
            AIVision.OnPlayerCatch.Invoke();
        }

        
        
    }

}
