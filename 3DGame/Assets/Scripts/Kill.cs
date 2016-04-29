public class kill : MonoBehaviour {
	
	public float x;
	public float y;
	public float z;
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter (Collider other) {
		x = other.transform.position.x;
		y = other.transform.position.y;
		z = other.transform.position.z;
		float movingX = -x;
		float movingY = -1 * (y-10);
		float movingZ = -1 * (z-10);
		other.transform.Translate(movingX,movingY,movingZ);
		
		
	}
