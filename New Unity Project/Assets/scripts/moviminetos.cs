using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moviminetos : MonoBehaviour{
    public float speed = 10.0f, fuerzaSalto = 10.0f;
    
    private Rigidbody Physics;
    // Start is called before the first frame update
    void Start(){
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Physics = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update(){
        float horizontal = Input.GetAxis("Horizontal");
        
        
        transform.Translate(new Vector3(horizontal, 0.0f, 0.0f) * Time.deltaTime * speed * -1);
        
        /*float rotacionCamara = Input.GetAxis("Mouse Y");
        transform.Rotate(new Vector3( 0.0f, 0.0f, rotacionCamara * Time.deltaTime * rotacion));*/

        if(Input.GetKeyDown(KeyCode.Space)){
            Physics.AddForce(new Vector3(0,fuerzaSalto,0), ForceMode.Impulse);
        }
    }
}
