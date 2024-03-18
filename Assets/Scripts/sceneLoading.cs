using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoading : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void loadMenu()
    {
        SceneManager.LoadScene("HUB");
    }

    public void loadApple()
    {
        SceneManager.LoadScene("APPLE");
    }

    public void loadHen()
    {
        SceneManager.LoadScene("HEN");
    }

    public void loadWell()
    {
        SceneManager.LoadScene("WELL");
    }

    public void loadGrabTry()
    {
        SceneManager.LoadScene("GRAB");
    }
}
