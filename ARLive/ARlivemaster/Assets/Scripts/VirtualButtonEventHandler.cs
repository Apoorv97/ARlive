using UnityEngine;

using Vuforia;

public class VirtualButtonEventHandler : MonoBehaviour, IVirtualButtonEventHandler
{
	private GameObject _model1;
	private GameObject _model2;
    private GameObject _model3;
    /// <summary>
    /// Called when the scene is loaded
    /// </summary>
    void Start() {
		// Search for all Children from this ImageTarget with type VirtualButtonBehaviour
VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
for (int i = 0; i < vbs.Length; ++i) {
    // Register with the virtual buttons TrackableBehaviour
    vbs[i].RegisterEventHandler(this);
}
_model1 = transform.FindChild("VirtualButton1").gameObject;
_model2 = transform.FindChild("VirtualButton2").gameObject;
        _model3 = transform.FindChild("VirtualButton3").gameObject;

_model3.SetActive(false);
_model2.SetActive(false);
	 }
 
    /// <summary>
    /// Called when the virtual button has just been pressed:
    /// </summary>
	
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) {
		switch(vb.VirtualButtonName) {
    case "VirtualButton1":
        _model1.SetActive(true);
        _model2.SetActive(false);
                _model3.SetActive(false);
            break;
    case "VirtualButton2":
        _model1.SetActive(false);
        _model2.SetActive(true);
                _model3.SetActive(false);
            break;
    case "VirtualButton3":
        _model1.SetActive(false);
        _model2.SetActive(false);
                _model3.SetActive(true);
        break;
            default:
        throw new UnityException("Button not supported: " + vb.VirtualButtonName);
            break;
}
	 }
 
    /// <summary>
    /// Called when the virtual button has just been released:
    /// </summary>
    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) { }
}