using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEditor.ProjectWindowCallback;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    string currentScene;
    string nextScene;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentScene = SceneManager.GetActiveScene().name;
        if (Input.GetKeyDown(KeyCode.Return)) {
            if (currentScene == "main menu") {
                nextScene = "game scene";
                SceneManager.LoadScene(nextScene);
            }
            else if (currentScene == "game scene") {
                nextScene = "credit screen";
                SceneManager.LoadScene(nextScene);
            }
            else if (currentScene == "end screen") {
                Application.Quit();
            }   
        }
    }
}
