using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwapNight : MonoBehaviour
{
    public void OnClickStart()
    {
        SceneManager.LoadScene("Sunny");
    }
}

