using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceAwake : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.currentNumberDestroyedStones = 0;
        GameManager.currentNumberStonesThrown = 0;
    }

    public void Click()
    {
        SceneManager.LoadScene("stoneScene");
    }

}
