using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    [SerializeField] private string nomDeScene;
    
    public void SceneSwitch()
    {
        SceneManager.LoadScene(nomDeScene);
    }
}
