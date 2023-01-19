using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GrabObjecs : MonoBehaviour
{
    [SerializeField]
    private Transform grabPoint;

    [SerializeField]
    private Transform rayPoint;
    [SerializeField]
    private float rayDistace;

    private GameObject grabbedObject;
    private int layerIndex;

    // Start is called before the first frame update
    void Start()
    {
        layerIndex = LayerMask.NameToLayer("Objects");
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(rayPoint.position, transform.right, rayDistace);

        if (hitInfo.collider != null && hitInfo.collider.gameObject.layer == layerIndex)
        {
            if (Input.GetButtonDown("k") && grabbedObject == null)
            {
                grabbedObject = hitInfo.collider.gameObject;
               // grabbedObject.transform.position = grabPoint.position;
                grabbedObject.GetComponent<Rigidbody2D>().isKinematic = true;
                grabbedObject.transform.SetParent(transform);
                
            }
            else if (Input.GetButtonUp("k"))
            {                
                grabbedObject.GetComponent<Rigidbody2D>().isKinematic = false;
                grabbedObject.transform.SetParent(null);
               
                grabbedObject = null;
            }
            Debug.DrawLine(rayPoint.position, transform.right * rayDistace);
        }
    }
}
