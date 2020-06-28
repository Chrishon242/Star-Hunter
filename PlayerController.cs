using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour
{
    public GameObject explosionSpawn;
    MeshRenderer renderShip;
    RevampCloak Cloak;
    Button buttonEnable;
    ActiveCloakBar cloakBarEnabled;
    ScoreOverTime score;
    public VariableJoystick joystick;
    Vector3 CamPos;
    Camera camera;
    public float NegX;
    public float PosX;
    


    private void Start()
    {
        Cloak = GetComponent<RevampCloak>();
        buttonEnable = FindObjectOfType<Button>();
        cloakBarEnabled = FindObjectOfType<ActiveCloakBar>();
        score = FindObjectOfType<ScoreOverTime>();
        rb = GetComponent<Rigidbody>();
        joystick = FindObjectOfType<VariableJoystick>();
        camera = Camera.main; 
        CamPos = camera.ViewportToWorldPoint(CamPos); 
    }






    //player stats
    public float Damage;
    public float speed;
    public float tilt;
    public float fireRate;
    public float CloakTime;
    public bool isActive;
    public Rigidbody rb;
    public Boundary boundary;
    float moveHorizontal;
    float moveVertical;
    float TouchHorizontal;
    float TouchVertical;
    Vector3 movement;
    Vector3 TouchMovement;


    void FixedUpdate()
    {

        ////////////////////////
        #region
        /////keyboard input
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        movement = new Vector3(moveHorizontal, 0, moveVertical);
        rb.velocity = movement * speed;


        /////Mobile Input 

        TouchHorizontal = joystick.Horizontal;
        TouchVertical = joystick.Vertical;
        TouchMovement = new Vector3(TouchHorizontal, 0, TouchVertical);

        rb.velocity = TouchMovement * speed;

        rb.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);

        rb.position = new Vector3
  (
      Mathf.Clamp(rb.position.x, CamPos.x + PosX, -CamPos.x + -PosX),
      0.0f,
      Mathf.Clamp(rb.position.z, -CamPos.z, CamPos.y)
  );

        rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -tilt);
        #endregion



    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MilkyAsteroids" ||
        other.gameObject.tag == "TropicalAsteroids" ||
        other.gameObject.tag == "LemonAsteroids" ||
        other.gameObject.tag == "VermillionAsteroids")
        {
            Instantiate(explosionSpawn, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
            buttonEnable.enabled = false;
            cloakBarEnabled.enabled = false;
            score.enabled = false;
            isActive = false;
        }

    }

}
 