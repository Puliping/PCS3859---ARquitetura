using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManualControl : MonoBehaviour
{
    // Start is called before the first frame update
    private bool movingup=false;
    private bool movingdown=false;
    private Vector3 up = Vector3.up;
    private Vector3 down = Vector3.down;
    public float speed;
    void Start()
    {
        up = Vector3.up*speed;
        down = Vector3.down*speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (movingup)
        {
            this.transform.position += up;
        }
        else if (movingdown)
        {
            this.transform.position += down;
        }
    }

    public void OnUp()
    {
        movingup = true;
    }
    public void ReleaseUp()
    {
        movingup = false;
    }

    public void OnDown()
    {
        movingdown = true;
    }
    public void ReleaseDown()
    {
        movingdown = false;
    }

}
