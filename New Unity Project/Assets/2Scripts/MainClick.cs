using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainClick : MonoBehaviour
{
    
    public void Click()
    {
        SceneManager.LoadScene(2);
    }
}