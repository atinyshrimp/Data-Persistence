using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField playerName;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetPlayerName()
    {
        DataManager.instance.playerName = playerName.text;
    }

    public void StartGame()
    {
        if (playerName.text != "")
            SceneManager.LoadScene(1);
    }

    public static void ExitGame()
    {

#if (UNITY_EDITOR)
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
