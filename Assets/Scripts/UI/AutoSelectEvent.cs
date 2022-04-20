using UnityEngine;
using UnityEngine.EventSystems;

public class AutoSelectEvent : MonoBehaviour
{
    public GameObject selection;
    private EventSystem eventSystem;

    private void Awake()
    {
        eventSystem = transform.parent.GetComponentInChildren<EventSystem>();
    }

    private void OnEnable()
    {
        eventSystem.SetSelectedGameObject(selection);
    }

    void Update()
    {

    }
}
