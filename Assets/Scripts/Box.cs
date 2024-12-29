using UnityEngine;

public class Box : MonoBehaviour
{
    public bool ileriHareketEdiyormu;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed=5;
        }
        else
        {
            speed = 2;
        }

        if (Input.GetKey(KeyCode.W))
         {
             transform.position = transform.position + Vector3.forward * speed * Time.deltaTime;
         }
         if (Input.GetKey(KeyCode.S))
         {
             transform.position = transform.position + Vector3.back * speed * Time.deltaTime;
         }
         if (Input.GetKey(KeyCode.A))
         {
             transform.position = transform.position + Vector3.left * speed * Time.deltaTime;
         }
         if (Input.GetKey(KeyCode.D))
         {
             transform.position = transform.position + Vector3.right * speed * Time.deltaTime;
         }
       

        /* transform.position = transform.position + Vector3.forward * speed * Time.deltaTime;

         if (Input.GetMouseButton(0))
         {
             transform.position = transform.position + Vector3.up * speed * Time.deltaTime;
         }
         else
         {
             transform.position = transform.position + Vector3.down * speed * Time.deltaTime;
         }*/
    }
}
