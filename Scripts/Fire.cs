using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
	public GameObject bullet;
	public GameObject bullet2;
	public GameObject bullet3;
	private GameObject bullets;
	public Transform firepos;
	private float speed;
	private bool bulon; //弾丸の発射間隔調節用
	public static int weaponchange;
	private bool weapchan;
	private bool reload;
	public static int bulcount;
	public static int bulcount2;
	public static int bulcount3;
	public static int allbulcount;
	public static int allbulcount2;
	public static int allbulcount3;
	//private AudioSource[] audioSources;

	// Use this for initialization
	void Start()
	{
		weaponchange = 0;
		speed = 1000f;
		bulon = true;
		weapchan = true;
		reload = true;
		bulcount = 6;
		bulcount2 = 60;
		bulcount3 = 3;
		allbulcount = 0;
		allbulcount2 = 0;
		allbulcount3 = 0;
		//audioSources = new AudioSource[4];
		//audioSources = GetComponents<AudioSource>();
	}

	// Update is called once per frame
	void Update()
	{
		
	}

	private void FixedUpdate()
	{
		if (Input.GetKeyDown(KeyCode.R) && reload == true)
		{
			reload = false;
			//audioSources[3].Play();
			Invoke("Reload", 0.5f);
		}
		if (Input.GetKeyDown(KeyCode.C) && weapchan == true)
		{
			weapchan = false;
			Invoke("Weapon", 0.5f);
		}
		if (weaponchange >= 3)
			weaponchange = 0;
		if (Input.GetMouseButton(0) && bulon == true && 
		    weaponchange == 0)
		{
			if (bulcount > 0)
			{
				//audioSources[0].Play();
				StartCoroutine("Shot1");
			}
		} else if (Input.GetMouseButton(0) && bulon == true && 
		           weaponchange == 1)
		{
			if (bulcount2 > 0)
			{
				//audioSources[1].Play();
				StartCoroutine("Shot2");
			}
		} else if (Input.GetMouseButton(0) && bulon == true && 
		           weaponchange == 2)
		{
			if (bulcount3 > 0)
			{
				//audioSources[2].Play();
				StartCoroutine("Shot3");
			}
		}
	}

	private IEnumerator Shot1()
	{
		bulon = false;
		bulcount--;
		//弾丸複製
        GameObject bullets = GameObject.Instantiate(bullet) as GameObject;

        Vector3 force;
        force = this.gameObject.transform.right * -speed;
        //rigidbodyに力を加えて発射
        bullets.GetComponent<Rigidbody>().AddForce(force);
        //弾丸の位置調整
        bullets.transform.position = firepos.position;
        Destroy(bullets, 2f);

		yield return new WaitForSeconds(0.5f);

		bulon = true;
	}

	private IEnumerator Shot2()
    {
        bulon = false;
		bulcount2--;
        //弾丸複製
        bullets = GameObject.Instantiate(bullet2) as GameObject;

        Vector3 force;
        force = this.gameObject.transform.right * -speed;
        //rigidbodyに力を加えて発射
        bullets.GetComponent<Rigidbody>().AddForce(force);
        //弾丸の位置調整
        bullets.transform.position = firepos.position;
        Destroy(bullets, 2f);

        yield return new WaitForSeconds(0.3f);

        bulon = true;
    }

	private IEnumerator Shot3()
    {
        bulon = false;
		bulcount3--;
        //弾丸複製
        bullets = GameObject.Instantiate(bullet3) as GameObject;

        Vector3 force;
        force = this.gameObject.transform.right * -speed;
        //rigidbodyに力を加えて発射
        bullets.GetComponent<Rigidbody>().AddForce(force);
        //弾丸の位置調整
        bullets.transform.position = firepos.position;
        Destroy(bullets, 2f);

        yield return new WaitForSeconds(1f);

        bulon = true;
    }
    
	private void Weapon()
    {
		weaponchange++;
		weapchan = true;
    }

    private void Reload()
	{
		if (weaponchange == 0 && allbulcount > 0)
		{
			int prebulcount = bulcount;
			prebulcount = 6 - prebulcount;
			if (allbulcount - prebulcount < 0)
			{
				bulcount += allbulcount;
				allbulcount = 0;
			}
			else
			{
				bulcount = 6;
				allbulcount -= prebulcount;
			}
		} 
		else if (weaponchange == 1 && allbulcount2 > 0)
		{
			int prebulcount = bulcount2;
            prebulcount = 60 - prebulcount;
            if (allbulcount2 - prebulcount < 0)
            {
                bulcount2 += allbulcount2;
                allbulcount2 = 0;
            }
            else
            {
                bulcount2 = 60;
                allbulcount2 -= prebulcount;
            }
		}
		else if (weaponchange == 2 && allbulcount3 > 0)
		{
			int prebulcount = bulcount3;
            prebulcount = 3 - prebulcount;
            if (allbulcount3 - prebulcount < 0)
            {
                bulcount3 += allbulcount3;
                allbulcount3 = 0;
            }
            else
            {
                bulcount3 = 3;
                allbulcount3 -= prebulcount;
            }
		}
		reload = true;
	}
}