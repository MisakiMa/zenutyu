using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour
{
    /// <summary>
    /// ターゲットへの参照
    /// </summary>
    public Transform target;

    private Vector3 offset; //相対座標

    // Start is called before the first frame update
    void Start()
    {
        //自分自身とtargetとの相対距離を求める
        offset = GetComponent<Transform>().position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().position = target.position + offset;
    }
}
