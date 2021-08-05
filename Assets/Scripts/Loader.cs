using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    public static Loader Instance;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
     void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void LoadMainMenu()
    {
        LoadScene(0);
    }

    public void LoadGameScene()
    {
        LoadScene(1);
    }

}
