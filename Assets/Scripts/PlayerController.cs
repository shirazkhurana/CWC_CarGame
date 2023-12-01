using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float player_speed= 20.0f;
    private float turn_speed = 15;
    private float horizontalInput;
    private float verticalInput;
    public GameObject al_camera;
    public GameObject main_Camera;
    private bool buttonCheck =true;
    // Start is called before the first frame update
    void Start()
    {
        al_camera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            
            if (!buttonCheck)
            {
                al_camera.SetActive(false);
                main_Camera.SetActive(true);
                buttonCheck = true;
            }

            else
            {
                al_camera.SetActive(true);
                main_Camera.SetActive(false);
                buttonCheck = false;
            }

           
        }


        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.forward * Time.deltaTime * player_speed* verticalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turn_speed* horizontalInput);
    }
}
