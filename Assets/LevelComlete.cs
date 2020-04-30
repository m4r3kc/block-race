using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelComlete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        Debug.Log("LoadNextLevel");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
