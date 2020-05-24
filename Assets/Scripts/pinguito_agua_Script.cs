using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinguito_agua_Script : MonoBehaviour
{
    public int NumPingos = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float H = Input.GetAxis("Horizontal");
        float V = Input.GetAxis("Vertical");
        transform.Translate(new Vector2(H * Time.deltaTime, V * Time.deltaTime));
    }



    private void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.CompareTag("pingo"))
        {
            //Destroy(outro.gameObject);
            NumPingos++;
            print(NumPingos);

        }
    }
}
