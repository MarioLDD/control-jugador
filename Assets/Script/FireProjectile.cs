using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    public Rigidbody projectile;
    float speedProjectile = 50;
    public UnityEngine.UI.Text textMuniciones;
    public UnityEngine.UI.Text textKills;
    public int municiones = 50;
    public int kills;
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && municiones > 0)
        {
            Rigidbody fire = Instantiate(projectile, transform.position, transform.rotation);
            fire.velocity = transform.forward * speedProjectile;
            municiones = municiones - 2;
            UpdateUI();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Item"))
        {
            Debug.Log("En el blanco");
            Destroy(collision.gameObject);
            kills++;

        }
    }
    void UpdateUI()
    {
        textMuniciones.text =municiones.ToString();
    }

}