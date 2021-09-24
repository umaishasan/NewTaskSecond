using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionPlayer : MonoBehaviour
{
    public GameObject player1;
    public GameObject goPanel;
    public Text scoreNumber;
    public Text lifeNumber;
    private int life = 110;
    private int Score = 0;

    void OnCollisionEnter(Collision collision)
    {
        var colliderObj = collision.collider.gameObject;
        Debug.Log(colliderObj.name + "(" + colliderObj.GetComponent<Renderer>().material.color.ToString()+")");
        Debug.Log(player1.name+"(" + player1.GetComponent<Renderer>().material.color.ToString()+")");

        if (player1.GetComponent<Renderer>().material.color == colliderObj.GetComponent<Renderer>().material.color)
        {
            Destroy(colliderObj);
            Score += 5;
            scoreNumber.text = Score.ToString();
            Debug.Log("Object hit with same color and score is: "+Score);
        }
        else
        {
            life -= 10;
            lifeNumber.text = life.ToString();
            Debug.Log("Object hit with different color and your life is: "+life);
            if(life <= 0)
            {
                Destroy(this);
                goPanel.SetActive(true);
            }
        }
    }
}
