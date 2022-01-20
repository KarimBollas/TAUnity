using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void SwitchMaze()
    {
        SceneManager.LoadScene(1);
    }
    public void SwitchSolar()
    {
        SceneManager.LoadScene(2);
    }
}
