using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InterfaceFinal : MonoBehaviour
{
    public Text textThrown;
    public Text textDestroyed;
    public Text textLives;
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
        textNotDestroyed.text = "Not Destroyed: " + GameManager.currentNumberOfStonesNotDestroyed;
        textLives.text = "Lifes: " + GameManager.currentNumberOfLives;
    }

    public void Click()
    {
        SceneManager.LoadScene("Awake");
    }
}
