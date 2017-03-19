using UnityEngine;
using System.Collections;

public class LerpShadowDistance : MonoBehaviour {

	//int timer;

	void Start () {
		//timer = 0;
		//float interval = Time.time / 5;
		//float lerpFactor = interval - Mathf.Floor(interval);
		
		// QualitySettings.shadowDistance = (Mathf.Lerp(2, 22, lerpFactor));
		//QualitySettings.shadowDistance = (Mathf.PingPong(Time.time*interval, 22));
		
		QualitySettings.shadowmaskMode = ShadowmaskMode.Shadowmask;
	}

	// Update is called once per frame
	void Update () {


		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			QualitySettings.shadowmaskMode = ShadowmaskMode.DistanceShadowmask;
		}

		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			QualitySettings.shadowmaskMode = ShadowmaskMode.Shadowmask;
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if(QualitySettings.shadowmaskMode == ShadowmaskMode.Shadowmask)
		{
			QualitySettings.shadowmaskMode = ShadowmaskMode.DistanceShadowmask;
		}else
		{
			QualitySettings.shadowmaskMode = ShadowmaskMode.Shadowmask;
		}
	}

	void OnTriggerExit()
	{


	}
}
