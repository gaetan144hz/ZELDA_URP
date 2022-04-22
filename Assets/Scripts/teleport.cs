using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.Serialization;

public class teleport : MonoBehaviour
{
    [Header("TP")]
    public GameObject Player;
    public CharacterController controller;
    public Transform tpToTarget;

    [Header("Inventaire")]
    private inventaire _inventaire;
    private reparation _reparation;
    public GameObject notAllowed;
    
    [Header("Animation Chargement")]
    public GameObject canvasLoading;
    public Animator canvasLoadingAnimator;
    public CanvasGroup canvasLoadingGroup;

    [Header("Camera")]
    public CinemachineVirtualCamera cvCamINT;
    [SerializeField] private int CamPriority;
    
    void Start()
    {
        canvasLoadingGroup.alpha = 0;
        _inventaire = FindObjectOfType<inventaire>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_inventaire.canOpen == true)
        {
            StartCoroutine(playLoadingAnim(other));
        }
        else
        {
            notAllowed.SetActive(true);
        }
    }

    public IEnumerator playLoadingAnim(Collider other)
    {
        controller.enabled = false;
        canvasLoading.SetActive(true);
        canvasLoadingAnimator.SetBool("load",true);
        yield return new WaitForSeconds(1f);
        cvCamINT.m_Priority = CamPriority;
        other.gameObject.transform.position = tpToTarget.position;
        other.gameObject.transform.rotation = tpToTarget.rotation;
        controller.enabled = true;
        canvasLoadingAnimator.SetBool("load",false);
    }

    private void OnTriggerExit(Collider other)
    {
        notAllowed.SetActive(false);
    }
}
