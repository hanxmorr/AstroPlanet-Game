using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScore : MonoBehaviour
{
    public int score = 0;
    void Update()
    {
        GetComponent<TextMesh>().text = score.ToString();
        if (score == 10)
        {
            Time.timeScale = 0;
            SceneManager.LoadScene("Complete");
        }
    }
}
