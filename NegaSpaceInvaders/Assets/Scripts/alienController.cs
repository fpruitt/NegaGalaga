using UnityEngine;
using System.Collections;

public class alienController : MonoBehaviour {

	public int speed;
	public bool collidingUp;
	public bool collidingDown;
	public bool collidingLeft;
	public bool collidingRight;
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKey ("up") && collidingUp == false) {
			transform.Translate (0, (-Time.deltaTime * speed), 0);
			collidingDown = false;
				}

		if (Input.GetKey("up") && collidingUp == true){
			collidingDown = false;
		}

		if (Input.GetKey("down") && collidingDown == false){
			transform.Translate(0, (Time.deltaTime * speed), 0);
			collidingUp = false;
		}

		if (Input.GetKey("down") && collidingDown == true){
			collidingUp = false;
			
		}

		if (Input.GetKey("left") && collidingRight == false){
			transform.Translate((Time.deltaTime * speed), 0, 0);
			collidingLeft = false;
		}
		
		if (Input.GetKey("left") && collidingRight == false){
			collidingLeft = false;
		}

		if (Input.GetKey("right") && collidingLeft == false){
			transform.Translate((-Time.deltaTime * speed), 0, 0);
			collidingRight = false;
		}
		
		if (Input.GetKey("right") && collidingLeft == false){
			collidingRight = false;
			
		}
	}
	
	void OnTriggerEnter(){
		collidingUp = true;
		collidingDown = true;
		
		
	}
	
}
