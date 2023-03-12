using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour{
    //public GameObject player;
    //public float offset;
    //private Vector3 playerPosition;
    //public float offsetSmoothing;
    public float FollowSpeed = 2f;
    public float yOffset = 1f;
    public Transform target;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update() {
        Vector3 newPos = new Vector3(target.position.x,target.position.y + yOffset,-10f);
        transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed*Time.deltaTime);


        //playerPosition = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        ////transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        //if(player.transform.localScale.x > 0f) {
        //    playerPosition = new Vector3(playerPosition.x + offset, playerPosition.y, playerPosition.z);
        //} else {
        //    playerPosition = new Vector3(playerPosition.x - offset, playerPosition.y, playerPosition.z);
        //}
        //// to change camera to move smoothly to right position
        //transform.position = Vector3.Lerp(transform.position, playerPosition, offsetSmoothing * Time.deltaTime);
    }   
}
