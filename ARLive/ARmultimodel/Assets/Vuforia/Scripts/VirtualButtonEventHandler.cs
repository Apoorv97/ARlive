using UnityEngine;

using Vuforia;

public class VirtualButtonEventHandler : MonoBehaviour, IVirtualButtonEventHandler
{
	private GameObject _model1;
	private GameObject _model2;
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
_model1 = transform.FindChild("Avent").gameObject;
_model2 = transform.FindChild("meceliago").gameObject;

_model2.SetActive(false);
	 }
 
    /// <summary>
    /// Called when the virtual button has just been pressed:
    /// </summary>
	
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) {
		switch(vb.VirtualButtonName) {
    case "b1":
        _model1.SetActive(true);
        _model2.SetActive(false);
               
            break;
    case "b2":
        _model1.SetActive(false);
        _model2.SetActive(true);
               
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