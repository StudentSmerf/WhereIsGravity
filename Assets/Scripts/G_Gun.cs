using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G_Gun : MonoBehaviour
{
    private LineRenderer lr;
    private Vector3 grapplePoint;
    public LayerMask whatIsGrappable;
    public Transform GunTip, camera1, Player;
    private float maxDistance = 100f;
    private SpringJoint joint;


    void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }



    void Update()
    {
        

        if (Input.GetMouseButtonDown(0))
        {
            if(PlayerPrefs.GetInt("IsGun") == 0){
            StartGrapple();
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            StopGrapple();
        }
    }

    void LateUpdate()
    {
        DrawRope();
    }


    void StartGrapple()
    {
        RaycastHit hit;
        if (Physics.Raycast(camera1.position, camera1.forward, out hit, maxDistance))
        {
            grapplePoint = hit.point;
            joint = Player.gameObject.AddComponent<SpringJoint>();
            joint.autoConfigureConnectedAnchor = false;
            joint.connectedAnchor = grapplePoint;

            float distanceFromPoint = Vector3.Distance(Player.position, grapplePoint);

            joint.maxDistance = distanceFromPoint * 0.8f;
            joint.minDistance = distanceFromPoint * 0.05f;


            joint.spring = 25f;
            joint.damper = 10f;
            joint.massScale = 8f;

            lr.positionCount = 2;
        }
    }

    void DrawRope()
    {
        if (!joint) return;

        lr.SetPosition(0, GunTip.position);
        lr.SetPosition(1, grapplePoint);
    }


    void StopGrapple()
    {
        lr.positionCount = 0;
        Destroy(joint);
    }


}
