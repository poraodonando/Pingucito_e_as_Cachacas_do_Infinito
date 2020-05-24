using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinguco_3pulos_Script : MonoBehaviour
{
    public Rigidbody2D pingu;
    public int NumPulos = 1;
    public bool liberaPulo;

    void Start()
    {
        liberaPulo = false;
    }

    // Update is called once per frame
    void Update()
    {
        float H = Input.GetAxis("Horizontal");
        transform.Translate(new Vector2(H * Time.deltaTime,0));

        if (NumPulos >= 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                pingu.AddForce(new Vector2(0, 200 * Time.deltaTime), ForceMode2D.Impulse);
                NumPulos--;
            }

           

        }
        else
        {
            liberaPulo = false;
        }

        
    }

    private void OnCollisionEnter2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("solo"))
        {
            NumPulos = 2;
            liberaPulo = true;
        }
        if (outro.gameObject.CompareTag("madeira"))
        {
            NumPulos = 2;
            liberaPulo = true;
        }

        if (outro.gameObject.CompareTag("madeiraD"))
        {
            NumPulos = 1;
            liberaPulo = true;
        }
    }
}
