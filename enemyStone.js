function OnCollisionEnter2D(coll: Collision2D) {
	//if (coll.gameObject.tag == "ENEMY")
		coll.gameObject.SendMessage("HAM");
}