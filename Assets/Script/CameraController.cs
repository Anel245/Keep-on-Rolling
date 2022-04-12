//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class CameraController : MonoBehaviour
//{
//    public GameObject target;
//    //public float xOffset, yOffset, zOffset;
//    public float Horizontal_Input;
//    public float Vertical_Input;
    
//    void Update()
//    {
//        transform.position = target.transform.position + new Vector3(Horizontal_Input, 0, Vertical_Input);
//        transform.LookAt(target.transform.position);
//    }
//    public void OnMovement(InputAction.CallbackContext context)
//    {
//        Horizontal_Input = context.ReadValue<Vector2>().x;
//        Vertical_Input = context.ReadValue<Vector2>().y;
//    }

//}
