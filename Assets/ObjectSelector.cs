using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelector : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    private bool movingup = false;
    private bool movingdown = false;
    private Vector3 up = Vector3.up;
    private Vector3 down = Vector3.down;
    public float speed;


    public GameObject chair;
    public GameObject stove;
    public GameObject fridge;
    private GameObject selected;
    void Start()
    {
        Chair(); // REMOVE THIS LATER
        up = Vector3.up * speed;
        down = Vector3.down * speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (movingup)
        {
            selected.transform.Rotate(up);
        }
        else if (movingdown)
        {
            selected.transform.Rotate(down);
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



    public void Chair()
    {
        chair.SetActive(true);
        stove.SetActive(false);
        fridge.SetActive(false);
        selected = chair;
}


    public void Stove()
    {
        chair.SetActive(false);
        stove.SetActive(true);
        fridge.SetActive(false);
        selected = stove;
    }


    public void Fridge()
    {
        chair.SetActive(false);
        stove.SetActive(false);
        fridge.SetActive(true);
        selected = fridge;
    }

}
