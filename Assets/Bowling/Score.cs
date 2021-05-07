using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Score : MonoBehaviour
{
    public Text scoreText;
    public GameObject[] Bowls = null;

    int score = 0;

     Vector3 currentEulerAngles;

    // Update is called once per frame
    void Start()
    {
     scoreText.text = score.ToString();

    }
    void Update()
    {
        foreach(GameObject go in Bowls)
        {
            if(go == this.gameObject) 
            {
                continue;
            }
            
            currentEulerAngles = go.transform.eulerAngles;
            // if((currentEulerAngles[0] < 150)&&(!flag)){
            //     ++score;
            //     scoreText.text = score.ToString();
            // }
             //Debug.Log (currentEulerAngles[0]);   
            //Debug.Log (go.transform.eulerAngles);

        }
        
    }

}
