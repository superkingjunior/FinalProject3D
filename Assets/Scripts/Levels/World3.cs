using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class World3 : MonoBehaviour
{
    void Start()
    {
        DialogueManager.instance.Play("AI_3_1");

        //if (!AudioManager.instance.IsPlaying("Tropical"))
        //{
            //AudioManager.instance.Play("Tropical");
        //}
    }

    public static void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //loads next scene in scene management queue
    }
}
