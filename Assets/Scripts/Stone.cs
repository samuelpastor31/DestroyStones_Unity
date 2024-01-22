using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    public GameObject explosion;
    private const float yDie = -30.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < yDie)
        {
            Destroy(gameObject);
            if ( !gameObject.CompareTag("Bomb")) // Si el objeto no es una bomba
            {
            GameManager.currentNumberOfStonesNotDestroyed++;
            }
        }
        
    }

    private void OnMouseDown()
    {
        Destroy(Instantiate(explosion, transform.position, Quaternion.identity),/*Destruir  2 segundos despues*/ 2.0f);
        Destroy(gameObject);
        if ( !gameObject.CompareTag("Bomb")){ // Si el objeto no es una bomba
        GameManager.currentNumberDestroyedStones++;
            }

        if ( gameObject.CompareTag("Bomb")) // Si el objeto es una bomba
            {
                // Restar una vida si se toca una bomba
                GameManager.currentNumberOfLives--;
            }
    }
}
