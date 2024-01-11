using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroductionStory : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene("DungeonScene", LoadSceneMode.Single);
    }
}
