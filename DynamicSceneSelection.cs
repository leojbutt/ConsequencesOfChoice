using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneArray : MonoBehaviour
{
    //List of scenes available
    //List of scenes already visited
    public List<string> scenes = new List<string>();
    public List<string> usedScenes = new List<string>();

    //Add scenes to list
    public void Start()
    {
        scenes.Add("Empathy");
        scenes.Add("Euphoria");
        scenes.Add("Drowning");
        scenes.Add("Vertigo");
    }

    //Pick a random string from list
    //Load the scene
    //Remove scene from list of available scenes
    //Add scene to list of visited scenes
    public void RandomScene()
    {
        string randomString = scenes[Random.Range(0, scenes.Count)];
        SceneManager.LoadScene(randomString);
        scenes.Remove(randomString);
        usedScenes.Add(randomString);
    }
}
