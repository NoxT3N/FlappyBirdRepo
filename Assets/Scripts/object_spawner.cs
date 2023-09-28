using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object_spawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float queueTime;
    public float time = 0;
    GameObject obstacle;
    public float height;
    // Update is called once per frame
    void Update()
    {
        if(time>queueTime){
            GameObject go = Instantiate(obstacle);
            go.transform.position = transform.position+
            new Vector3(0,Random.Range(-height, height),0);
            time = 0;
            Destroy(go, 10);
        }
        time += Time.deltaTime;
    }
}
