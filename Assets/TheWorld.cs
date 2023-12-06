using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[ExecuteInEditMode]
public class TheWorld : MonoBehaviour  {

    public List<SceneNode> TheRoots;

    public void ResetScene()
    {
        // Get the current scene name using the SceneManager
        Scene currentScene = SceneManager.GetActiveScene();

        // Load it again
        SceneManager.LoadScene(currentScene.name);
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        foreach (SceneNode root in TheRoots) {
            Matrix4x4 i = Matrix4x4.identity;
            root.CompositeXform(ref i);
        }
    }
}
