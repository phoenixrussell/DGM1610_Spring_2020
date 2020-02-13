using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn Manager: MonoBehaviour
{
    public GameObject[] enemyPrefabs;
public int enemeyIndex;





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    if (Input.GetKeyDown(KeyCode.S))
    {
        Instantiate(enemyPrefabs[enemyIndex], new Vector3(0, 0, 0), enemyPrefabs[enemyIndex].transform.rotation);
    }


    }
}
