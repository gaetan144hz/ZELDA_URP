using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class reparation : MonoBehaviour
{
    [Header("Inventaire")]
    private inventaire _inventaire;

    public GameObject keyPrefabs;
    public Transform spwnPoint;

    public GameObject partUI;
    public GameObject vfxParticle;

    void Start()
    {
        _inventaire = FindObjectOfType<inventaire>();
    }

    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (gameObject.CompareTag("Player"))
        {
            partUI.SetActive(false);
        }
    }

    public void repare()
    {
        Instantiate(keyPrefabs, spwnPoint.position, Quaternion.identity);
        _inventaire.count = 0;
        _inventaire.counter.text = _inventaire.count.ToString("0");
        Destroy(this.gameObject,0.5f);
    }

    private void OnDestroy()
    {
        Instantiate(vfxParticle, transform.position, Quaternion.identity);
    }
}
