using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlayer : MonoBehaviour
{
    public List<GameObject> g = new List<GameObject>();
    public GameObject targetObj;
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
        for (int i = 0; i <= Count; i++)
        {
            yield return new WaitForSeconds(2);
            g.Add(Instantiate(targetObj));
            g[i].transform.position = new Vector3(Random.Range(-9, 10), 0.51f, Random.Range(0, 9));
            g[i].GetComponent<Renderer>().material.color = Color.HSVToRGB(Random.value, Random.value, Random.value);
            g[i].GetComponent<Rigidbody>().gameObject.active = true;
        }
    }
}
