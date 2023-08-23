using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chain : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer GameObjectSpriteRenderer;
    public Sprite sprite1;
    public Sprite sprite2;
    public float timeBetweenFrames;
    public bool StateSwitcher;
    public bool isAbleToSwitch;
    public string whereDoIGo;

    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(timeBetweenFrames);
        isAbleToSwitch = true;
        }

    void Start()
    {
        GameObjectSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        isAbleToSwitch = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (StateSwitcher == false && isAbleToSwitch == true)
        {
            GameObjectSpriteRenderer.sprite = sprite1;
            StateSwitcher = true;
            isAbleToSwitch = false;
            StartCoroutine("Waiter");
        }
        else if (StateSwitcher == true && isAbleToSwitch == true)
        {
            GameObjectSpriteRenderer.sprite = sprite2;
            StateSwitcher = false;
            isAbleToSwitch = false;
            StartCoroutine("Waiter");
            
        }

        

        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            
            SceneManager.LoadScene(whereDoIGo);
            Debug.Log("Do something else here");
        }
    }

}


//Fecha: futuro indefinido.
//Se ha llegado al límite de la explotación de recursos y eres el último arbolito vivo del planeta.
//Te enfrentas al último leñador que aún no es un robot. Su desprecio contra lo natural y lo vivo va contra ti.