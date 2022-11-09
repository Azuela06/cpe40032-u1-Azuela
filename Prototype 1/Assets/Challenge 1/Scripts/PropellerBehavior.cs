using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerBehavior : MonoBehaviour
{
    public float propel = 100;
    public GameObject player;
    private Vector3 axis = new Vector3(0, 0, 750.12f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(propel * Time.deltaTime * axis);
    }
}
