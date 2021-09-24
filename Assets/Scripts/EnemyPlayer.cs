using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlayer : MonoBehaviour
{
    public List<GameObject> g = new List<GameObject>();
    public GameObject targetObj;
    //public Color[] 
    //public int countObj;
    public int Counnnt;

    void Start()
    {
        StartCoroutine(GenerateEnemy(Counnnt));

       // InvokeRepeating("GenerateEnemyPlayer", 1, Random.Range(2, 5));
        Debug.Log("Enemy generating and decreasing count");
    }

   /* void GenerateEnemyPlayer()
     {
        if (countObj == 0)
        {
            return;
        }
        targetObj = Instantiate(targetObj);
        targetObj.transform.position = new Vector3(Random.Range(-9, 10), 0.51f, Random.Range(0, 9));
        targetObj.GetComponent<Renderer>().material.color = Color.HSVToRGB(Random.value, Random.value, Random.value);
        targetObj.GetComponent<Rigidbody>().gameObject.active = true;
        countObj--;
    }*/

    IEnumerator GenerateEnemy(int Count)
    {
        Color[] myColors = { Color.red, Color.green, Color.blue, Color.black, Color.yellow, Color.white, Color.cyan, Color.gray, Color.grey, Color.HSVToRGB(Random.value, Random.value, Random.value)};
        for (int i = 0; i <= Count; i++)
        {
            //random colors from array
            int randomColors = Random.Range(0, myColors.Length);

            //after 2 second object instentiate
            yield return new WaitForSeconds(2);
            g.Add(Instantiate(targetObj));

            //random colors,position etc.
            g[i].transform.position = new Vector3(Random.Range(-9, 10), 0.51f, Random.Range(0, 9));
            //10 colors...
            g[i].GetComponent<Renderer>().material.color = myColors[randomColors];
            //30 million...
            // g[i].GetComponent<Renderer>().material.color = Color.HSVToRGB(Random.value, Random.value, Random.value);
            g[i].GetComponent<Rigidbody>().gameObject.SetActive(true);
        }
    }
}
