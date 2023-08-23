using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviourFlipped : MonoBehaviour
{

    public float shSpeed;
    // Start is called before the first frame update
    // void Start() DELETED

    // Update is called once per frame
    private void Update()
    {
        transform.position -= transform.right * Time.deltaTime * shSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Respawn")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            
            Destroy(gameObject);
            Debug.Log("bul");
        }
    }
}
