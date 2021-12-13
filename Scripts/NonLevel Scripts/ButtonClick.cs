using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    public void OnStartClick()
    {
        SceneManager.LoadScene("Level Select");
    }
    public void OnInstructionsClick()
    {
        SceneManager.LoadScene("Instructions");
    }
    public void OnBackClick()
    {
        SceneManager.LoadScene("Title");
    }
    public void OnOneClick()
    {
        SceneManager.LoadScene("Level1");
    }
    public void OnTwoClick()
    {
        SceneManager.LoadScene("Level2");
    }
    public void OnThreeClick()
    {
        SceneManager.LoadScene("Level3");
    }
    public void OnFourClick()
    {
        SceneManager.LoadScene("Level4");
    }
    public void OnFiveClick()
    {
        SceneManager.LoadScene("Level5");
    }
}
