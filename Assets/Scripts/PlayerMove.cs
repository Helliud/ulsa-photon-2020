using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerMove : MonoBehaviour
{

    PhotonView photonView;

    [SerializeField, Range(0.1f, 10f)]
    float moveSpeed;

    void Awake()
    {
        photonView = GetComponent<PhotonView>();
    }

    void Update()
    {
        if(!photonView.IsMine) return;
        transform.Translate(Axis * moveSpeed * Time.deltaTime);
    }

    Vector3 Axis => new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

}
