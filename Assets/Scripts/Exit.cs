using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    
    public void goback()
    {
        SceneManager.LoadSceneAsync("Home Screen");
    }
}
