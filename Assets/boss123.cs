using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss123 : MonoBehaviour
{
    Rigidbody rb;
    public GameObject bulletPrefab; // 子彈來源 (在Unity介面中拖入)
    public GameObject firePoint; // 子彈來源 (在Unity介面中拖入)
    
    private CharacterController controller;

    void Start()
    {
        
        controller = GetComponent<CharacterController>();

        // 開始一直射擊的 Coroutine 函式
        StartCoroutine(KeepShooting());
    }

    void Update()
    {
        
        
    }
    void Fire()
    {
        Instantiate(bulletPrefab, firePoint.transform.position, transform.rotation);
    }    
    
    IEnumerator KeepShooting()
    {
        while (true)
        {
            // 射擊
            Fire();

            // 暫停 0.5 秒
            yield return new WaitForSeconds(0.5f);
        }
    }
}