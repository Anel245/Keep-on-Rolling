using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Patrolling : MonoBehaviour
{
      [SerializeField]
    public bool IsMovingRight;
    [SerializeField]
    float moveSpeed = 1f;
    public Transform LeftPos;
    public Transform RightPos;
    Transform CurrentTarget;
    public bool canStart;
    public float fraction;
    Vector3 start, des;
    public Rigidbody body;
    public bool culbool;
    void Start()
    {
        //LeftPos = transform.GetChild(0);
        //RightPos = transform.GetChild(1);
        start = LeftPos.position;
        des = RightPos.position;
        canStart = true;
        body = GetComponent<Rigidbody>();


    }

    void Update()
    {
        if (canStart)
        {

            canStart = false;
            StopAllCoroutines();
            StartCoroutine(MoveTo());

        }
    }
    IEnumerator MoveTo()
    {
        // While not there, move
        while (fraction < 1)
        {
            if(culbool == true)
            {
                body.velocity = 10 * Vector3.left;
            }
            else
            {
                body.velocity = 10 * Vector3.right;
            }
            fraction += Time.deltaTime * moveSpeed;
            //Debug.Log(Vector3.Lerp(start, des, fraction));
            //transform.position = Vector3.Lerp(start, des, fraction);
            //body.velocity = 10 * Vector3.left;
            //body.velocity = 10 * Vector3.right;
            yield return null;
        }

        // done, cleanup and swap targets
        //IsMovingRight = !IsMovingRight;

        fraction = 0f;
        canStart = true;

        //culbool = wechsel(culbool);
        var tmp = des;
        des = start;
        start = tmp;

    }

    private bool IsFacingRight()
    {

        return transform.localScale.x > Mathf.Epsilon;
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    collision.transform.SetParent(transform);
    //}
    // private void OnCollisionExit2D(Collision2D collision)
    //{
    //    collision.transform.SetParent(null);
    //}
    private bool wechsel(bool culbool)
    {
        return !culbool;
    }
    private void OnTriggerEnter(Collider other)
    {
        culbool = wechsel(culbool);
    }

    private void OnCollisionEnter(Collision collision)
    {
       // collision.transform.SetParent(transform);

    }

    private void OnCollisionEnterExit(Collision collision)
    {
        //collision.transform.SetParent();

    }
}
