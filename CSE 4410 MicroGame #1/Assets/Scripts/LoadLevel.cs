using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour
{
    public void OnMouseClick() 
    {
        SceneManager.LoadScene("Game");
        //enabled = true;
    }

    public void QuitGame() 
    {
        Application.Quit();
        Debug.Log("Game has been quit");
    }

}
