using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceStone : MonoBehaviour
{
    public Text textThrown;
    public Text textDestroyed;
    public Text lifes;
    public Text textNotDestroyed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textThrown.text = "Number of stones: " + GameManager.currentNumberStonesThrown;
        textDestroyed.text = "Destroyed: " + GameManager.currentNumberDestroyedStones;
        textNotDestroyed.text = "Not destroyed: " + GameManager.currentNumberOfStonesNotDestroyed;
        lifes.text = "Lifes: " + GameManager.currentNumberOfLives;
    }
}
