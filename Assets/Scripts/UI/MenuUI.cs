using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using System.IO;

public class MenuUI : MonoBehaviour
{
    public Text player;
    public Text highScore;
   
    private void Awake()
    {
        LoadData();
    }
    public void ResetData()
    {
        SaveData data = new SaveData();



        data.score = 0;
        data.name = " ";

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);

        LoadData();
    }
    private void LoadData()

    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            player.text = data.name;
            highScore.text = data.score.ToString();
        }
    }
    public void LoadGame()

    {
        Loader.Instance.LoadGameScene();
    }
   public void Exit()

    {
        Application.Quit();
        EditorApplication.ExitPlaymode();       
    }
}
