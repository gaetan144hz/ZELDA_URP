using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class inventaire : MonoBehaviour
{
    public TextMeshProUGUI counter;
    public int count;
    public int oneKey;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void takeKey()
    {
        count += oneKey;
        counter.text = count.ToString("0");
    }
}
