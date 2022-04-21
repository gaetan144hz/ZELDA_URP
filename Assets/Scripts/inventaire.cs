using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class inventaire : MonoBehaviour
{
    public TextMeshProUGUI counter;
    public int count;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void takeKey()
    {
        count += 1;
        counter.text = count.ToString("0");
    }
}
