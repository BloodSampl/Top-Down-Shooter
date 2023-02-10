using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class UI : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
