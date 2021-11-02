
using UnityEngine;

public class PlayerMovemoent : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
   
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, sidewaysForce * Time.deltaTime, 0);
        }

        if (rb.position.y < -1f)      //î@â à íuí·âóy-1ìIòbÊ\·¢
        {
            FindObjectOfType<GameManager>().EndGame();    //íºê⁄êqùQï®åèìIóﬁï GameManager
        }


    }
}
