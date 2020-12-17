using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticlesystem : MonoBehaviour
{
    //オブジェクトの消滅時間
    public float destroyTime = 5f;

    void Start()
    {
        //コールチンdestroyParticlesytemのコール
        StartCoroutine(destroyParticlesytem());
    }

    //オブジェクトを指定された時間で消滅させる
    IEnumerator destroyParticlesytem()
    {
        yield return new WaitForSeconds(destroyTime);
        Destroy(this.gameObject);
    }
}
