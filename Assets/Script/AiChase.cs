using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class AiChase : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float rotateSpeed;
    public float Damage;

    public bool canMove = true;
    public bool retreat;

    private float distance;

    private void Update()
    {
        if (canMove)
        {
            if(player != null)
            {
                distance = Vector2.Distance(transform.position, player.transform.position);
            }
            Vector2 direction = player.transform.position - transform.position;

            if(!retreat)
            {
                transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            }
            else
            {
                transform.position = Vector2.MoveTowards(this.transform.position, -transform.position, 20 * Time.deltaTime);
            }


            Vector2 targetDirection = player.transform.position - transform.position;
            float angle = math.atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg - 90;
            Quaternion q = Quaternion.Euler(new Vector3(0, 0, angle));
            transform.localRotation = Quaternion.Slerp(transform.localRotation, q, rotateSpeed);
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            col.gameObject.GetComponent<Health>().TakeDamage(Damage);
            Destroy(gameObject);
        }
    }


    public void test()
    {
        StartCoroutine(Wait());
    }
    public IEnumerator Wait()
    {
        canMove=false;
        yield return new WaitForSeconds(2);
        canMove = true;
    }
    IEnumerator damageWait()
    {
        Debug.Log("coll");
        retreat = true;
        yield return new WaitForSeconds(0.1f);
        retreat = false;
        canMove = false;
        yield return new WaitForSeconds(0.5f);
        canMove = true;

    }
}
