using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour {
	public GameObject Gun;
	public GameObject Crash;
	public static int enecount; //残り敵数
	private int Enecount; //何体生成するか
	public static string EFPstr;
	private bool creon;
	public static int enemyhp;

	private void Awake()
	{
		for (int i = 0; i < 2; i++)
		{
			Move_Enemy.ENum[i] = i + 1;
		}
	}

	// Use this for initialization
	void Start () {
		enecount = 0;
		enemyhp = 10;
		Enecount = 2;
		creon = true;
		Create();
	}
	
	// Update is called once per frame
	void Update () {
		if (enecount == 0 && creon == true)
		{
			creon = false;
			Enecount++;
			if (Enecount > 8)
			{
				enemyhp += 10;
				Enecount = 2;
			}
			Wave_Text.curwave++;
			Create();
			creon = true;
		}
	}

    void Create()
	{
		for (int i = 0; i < Enecount; i++)
        {
            float x = Random.Range(-29f, 29f);
            float y = 0.5f;
            float z = 31f;
            Vector3 position = new Vector3(x, y, z);
            //敵を生成
            GameObject EneClone = Instantiate(Gun, position, Quaternion.Euler(0f, 180f, 0f)) as GameObject;
            enecount++;
            /*
            //生成された敵の名前の変更
            string EneName = "Gun_Enemy" + (i + 1);
            EneClone.name = EneName;
            //生成された敵の名前の子オブジェクトを取得
            var ChildTransform = GameObject.Find(EneName).transform;
            foreach (Transform child in ChildTransform.transform)
            {
                EFPstr = "EFP" + (i + 1);
                child.tag = EFPstr;
                child.name = "EneFirePos" + (i + 1);
            }
            */
        }
		for (int i = 0; i < Enecount; i++)
        {
            float xc = Random.Range(-49f, 49f);
            float yc = 0.5f;
            float zc = 31f;
            Vector3 cposition = new Vector3(xc, yc, zc);
            //突進する敵を生成
            GameObject CraEneClone = Instantiate(Crash, cposition, Quaternion.Euler(0f, 180f, 0f));
            enecount++;
            /*
            //生成された敵の名前の変更
            string CraEneName = "Crash_Enemy" + (i + 1);
            CraEneClone.name = CraEneName;
            //生成された敵の名前の子オブジェクトを取得
            var CrashChild = GameObject.Find(CraEneName).transform;
            foreach (Transform child in CrashChild.transform)
            {
                string Crashstr = "CraChild" + (i + 1);
                child.name = Crashstr;
            }
            */
        }
	}
}
