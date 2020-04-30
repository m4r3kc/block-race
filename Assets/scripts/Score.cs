using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
  
    public Transform player;
    public Text scoreText;
    // Update is called once per frame
    void Update()
    {
    double result = player.position.z + 30;
    scoreText.text = result.ToString("0");
        //player.position.z;
    }
}
