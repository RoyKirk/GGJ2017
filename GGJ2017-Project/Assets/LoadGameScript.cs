using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;


public class LoadGameScript : MonoBehaviour {

    public void LoadGame()
    {
        SceneManager.LoadScene("royProto");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ContinueGame()
    {
        transform.parent.gameObject.SetActive(false);
    }
}
