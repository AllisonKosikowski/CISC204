using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBack : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
