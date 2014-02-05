
var eyeOpen = true;

function Update() {
 
    if (Input.GetKeyDown(KeyCode.Z)) {
        // toggle visibility:
        renderer.enabled = !renderer.enabled;
		eyeOpen = !eyeOpen;
    }
}