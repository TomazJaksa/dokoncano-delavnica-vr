using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Premikaj : MonoBehaviour
{

    public Vector3 premakni;
    public float initX;
    public float initY;
    public float initZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(premakni*Time.deltaTime);

        Debug.Log(transform.position.z);
        if (transform.position.z <= -33) {
            transform.position = new Vector3(initX,initY,initZ);


        }
    }
}
