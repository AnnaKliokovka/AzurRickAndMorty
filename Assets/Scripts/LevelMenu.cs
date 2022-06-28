using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    public PlayerState playerState;
    // Start is called before the first frame update
    void Start()
    {
        transform.localPosition = Vector3.zero;
        gameObject.SetActive(false);
    }
    
    public void LoadFirstLevel()
    {
        playerState.level = 0;
        playerState.Save();
        SceneManager.LoadScene(1);
    }
    
    public void LoadSecondLevel()
    {
        playerState.level = 1;
        playerState.Save();
        SceneManager.LoadScene(1);
    }

    public void LoadThirdLevel()
    {
        playerState.level = 2;
        playerState.Save();
        SceneManager.LoadScene(1);
    }
}
