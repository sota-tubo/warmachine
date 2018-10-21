using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireR : MonoBehaviour {
	public GameObject Enebul;
    private Transform Enefirepos;
    private bool fireon;
    //public static int EC = 2; //Wave.EFPCountと同値
    //public static int[] ENum = new int[100];

    // Use this for initialization
    void Start()
    {
        /*
        //子オブジェクトのtagを判別する
        for (int i = 0; i < EC; i++)
        {
            string efpst = "EFP" + ENum[i];
            if (this.gameObject.transform.GetChild(0).tag == efpst)
            {
                Enefirepos = GameObject.FindGameObjectWithTag(this.gameObject.transform.GetChild(0).tag)
                                       .transform;
            }
        }
        
        var ChildTrans = GameObject.Find(gameObject.name).transform;
        foreach (Transform child in ChildTrans.transform)
        {
            GameObject childobj = child.gameObject;
            Enefirepos = childobj.transform;
        }
        */
        fireon = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (fireon == true)
            {
                fireon = false;
                /*
                for (int i = 0; i < transform.childCount; i++)
                {
                    Enefirepos = transform.GetChild(i);
                }
                */
                Enefirepos = transform.GetChild(8);
                StartCoroutine("EneShot");
            }
        }
        else if (other.tag == "Base")
        {
            if (fireon == true)
            {
                fireon = false;
                StartCoroutine("EneShot");
            }
        }
    }

    private IEnumerator EneShot()
    {
        float Enebulspeed = 500f;
        //弾丸複製
        GameObject Enebullets = GameObject.Instantiate(Enebul) as GameObject;

        Vector3 force;
        force = this.gameObject.transform.forward * Enebulspeed;
        //rigidbodyに力を加えて発射
        Enebullets.GetComponent<Rigidbody>().AddForce(force);
        //弾丸の位置調整
        Enebullets.transform.position = Enefirepos.position;
        /*
        var Enebullets = (GameObject)Instantiate(Enebul, Enefirepos.position,
                                              Enefirepos.rotation);
		Enebullets.GetComponent<Rigidbody>().velocity = Enebullets.transform.forward * 6;
		*/
        Destroy(Enebullets, 2f);

        yield return new WaitForSeconds(1f);

        fireon = true;
    }
}
