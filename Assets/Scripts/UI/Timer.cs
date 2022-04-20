using System.Collections;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float currentTime;
    [SerializeField] float startingTime;

    [SerializeField] TextMeshProUGUI countdownText;

    void Awake()
    {
        currentTime = startingTime;
    }

    public void timeInstantiate()
    {
        StartCoroutine(timeCount());
    }

    IEnumerator timeCount()
    {
        while(true)
        {
            currentTime += 1;
            countdownText.text = currentTime.ToString("0");
            yield return new WaitForSeconds(1);
        }
    }
}
