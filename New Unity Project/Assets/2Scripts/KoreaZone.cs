using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class KoreaZone : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        SceneManager.LoadScene(5);
    }

    public void Click()
    {
        SceneManager.LoadScene(5);
    }
}