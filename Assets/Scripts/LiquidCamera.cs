using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiquidCamera : MonoBehaviour
{

    public PlayerState playerState;
    // Start is called before the first frame update
    void Start()
    {
        if (playerState.level == 2)
        {
            this.gameObject.SetActive(true);
        }
        else
        {
            this.gameObject.SetActive(false);
        }
    }

}
