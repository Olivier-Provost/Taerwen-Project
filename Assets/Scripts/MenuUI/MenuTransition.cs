using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuTransition : MonoBehaviour {

    public void ButtonPressed(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

    }
}
