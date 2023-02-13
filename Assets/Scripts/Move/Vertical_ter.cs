using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Vertical_ter : MonoBehaviour{

    void Update(){
        RaycastHit hit;

        int Rmask = LayerMask.GetMask ("Terrain");

        Vector3 Point_dir = transform.TransformDirection(Vector3.down);

        if (Physics.Raycast(transform.position, Point_dir, out hit, 50.0f,Rmask)) {

            Quaternion nextRot=Quaternion.LookRotation(Vector3.Cross(hit.normal,Vector3.Cross(transform.forward,hit.normal)),hit.normal);

            GetComponent<Rigidbody>().MoveRotation(Quaternion.Lerp(transform.rotation,nextRot,0.1f));

        }
    }
}
