using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    private Vector3 direction;
    public float upwardSpeed;
    public float boostSpeed;
    private CharacterController controller;
    // Start is called before the first frame update

    //-2x
    //2
        void Start()
        {
        controller = GetComponent<CharacterController>();
        }
    // Update is called once per frame
        void Update()
        {
        direction.y = upwardSpeed;
        controller.Move(direction * Time.fixedDeltaTime);

         }
        private void OnTriggerEnter(Collider collision)
        {
            if (collision.gameObject.CompareTag("BoostObject"))
            {
            collision.gameObject.SetActive(false);
            GetComponent<Rigidbody>().velocity += transform.forward * boostSpeed;

             }
         }
        private void OnControllerColliderHit(ControllerColliderHit hit)
        {
            if (hit.transform.tag == "Obstacle")
            {
            SceneManager.LoadScene("EndScreen");
            }
        }
}
