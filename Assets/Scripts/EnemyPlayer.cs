using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlayer : MonoBehaviour
{
    List<GameObject> glist = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        generateEnemyPlayer();
        Debug.Log("Enemy generate");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void generateEnemyPlayer()
    {
        for (int i = 0; i < 5; i++)
        {
            glist.Add(GameObject.CreatePrimitive(PrimitiveType.Cube));
            glist[i].transform.position = new Vector3(Random.Range(0, 10), 0.51f, Random.Range(0, 9));
            glist[i].GetComponent<Renderer>().material.color;
        }
    }
}
