using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cria_Cuspe_Script : MonoBehaviour
{

    public GameObject boca,cuspe;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.H)) {
            Instantiate(cuspe, new Vector3(boca.transform.position.x, boca.transform.position.y, boca.transform.position.z), boca.transform.rotation);
        }

        
    }
}
