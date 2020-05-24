using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinguguito_Script : MonoBehaviour
{
   
    public Rigidbody2D pingu;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float H = Input.GetAxis("Horizontal");
        transform.Translate(new Vector2(H * Time.deltaTime, 0));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            pingu.AddForce(new Vector2(0, 200 * Time.deltaTime), ForceMode2D.Impulse);
        }

    }
}
