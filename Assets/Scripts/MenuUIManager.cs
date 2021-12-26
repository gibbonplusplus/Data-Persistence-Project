using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Canvas/Best Score Text").GetComponent<TMP_Text>().text =
            "Best Score: " +
            DataManager.Instance.highscoreName +
            ": " +
            DataManager.Instance.highscore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        DataManager.Instance.playerName = GameObject.Find("Canvas/Enter Name").GetComponent<TMP_InputField>().text;

        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
