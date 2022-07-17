using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int basScore = 0;
    public int playerscore;
    public int score = 0;
    public GameObject[] other;
    public Text scoreDisplay;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Finish"))
        {
            playerscore= basScore += score;
            Debug.Log(playerscore);
            scoreDisplay.text = playerscore.ToString();
        }
    }
}
