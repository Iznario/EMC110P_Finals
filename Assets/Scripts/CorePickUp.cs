using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CorePickUp : MonoBehaviour
{
    public GameObject ScoreText;
    public int theScore;
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        theScore += 10;
        ScoreText.GetComponent<Text>().text= "Score: " + theScore;
        Destroy(gameObject);
    }
}
