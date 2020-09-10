using UnityEngine;
using System.Collections;

public class BackGroundShake : MonoBehaviour
{

    [SerializeField] public GameObject girl;
	public bool isEnable = true;
    public bool isEplayed = true;
    public Vector3 shakedegree = Vector3.one * 0.1f;
	public float addDegreeTime = 2;

	private Vector3 originPosition;
	private float timeCount;

	void Start()
	{
		originPosition = transform.localPosition;
	}

	void Update()
	{
		if (isEnable)
		{
            if (isEplayed)
            {
                girl.GetComponents<AudioSource>()[0].Play();
                isEplayed = false;
            }
            if (timeCount < addDegreeTime)
                timeCount += Time.deltaTime;
            else
            {
                timeCount = addDegreeTime;
                isEnable = false;
            }
			transform.localPosition = new Vector3(GetX(), GetY(), GetZ());
		}
		else
		{
			if (timeCount > 0)
			{
				timeCount -= Time.deltaTime;

				transform.localPosition = new Vector3(GetX(), GetY(), GetZ());
			}
			else
			{
				transform.localPosition = originPosition;
			}
		}
	}

	private float GetX()
	{
		return originPosition.x + Random.Range(-1 * timeCount * shakedegree.x, timeCount * shakedegree.x);
	}
	private float GetY()
	{
		return originPosition.y + Random.Range(-1 * timeCount * shakedegree.y, timeCount * shakedegree.y);
	}
	private float GetZ()
	{
		return originPosition.z + Random.Range(-1 * timeCount * shakedegree.y, timeCount * shakedegree.y);
	}
}