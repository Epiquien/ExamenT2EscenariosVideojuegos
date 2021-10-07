using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoAttack : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    public float velocityX = -2f;
    // Start is called before the first frame update
    
   // public GameObject EnemigoNinja;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
      //  StartCoroutine("Esperar");
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(velocityX, rb.velocity.y);
    }
    
  /*  IEnumerator Esperar()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("paso 5 segundos");
       
        var zombie =   EnemigoNinja;
        var position = new Vector2(9.94f, -2.41f);
        var rotation = EnemigoNinja.transform.rotation;
        
        Instantiate(zombie, position, rotation);
    }  */
}
