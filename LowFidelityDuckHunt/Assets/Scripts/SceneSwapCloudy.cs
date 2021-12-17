using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwapCloudy : MonoBehaviour
{
    public void OnClickStart()
    {
        SceneManager.LoadScene("Night");
    }
}

