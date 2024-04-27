using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUp : MonoBehaviour
{
    private bool touchingSquirrel;
    private bool bin;
    private bool holdingSquirrel;
    private GameObject target;
    public GameObject hand;

private void Start(){
    touchingSquirrel = false;
    hand.SetActive(false);
    bin = false;
    holdingSquirrel = false;
}
private void OnTriggerEnter(Collider other){
    if (other.gameObject.tag == "Enemy"){
        touchingSquirrel = true;
        target = other.gameObject;
        Debug.Log(touchingSquirrel + target.name);
    } else if (other.gameObject.tag == "SquirrelBin"){
        bin = true;
    }
}
private void OnTriggerExit(Collider other){
    if (other.gameObject.tag == "Enemy"){
        touchingSquirrel = false;
        Debug.Log(touchingSquirrel);
    } else if (other.gameObject.tag == "SquirrelBin"){
        bin = false;
    }
}
private void Update(){
    if (touchingSquirrel && Input.GetKeyDown(KeyCode.E) && !holdingSquirrel){
        Destroy(target);
        hand.SetActive(true);
        holdingSquirrel = true;
    }
    if (bin){
        hand.SetActive(false);
        holdingSquirrel = false;
    }
}
}
