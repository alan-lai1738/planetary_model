using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class XfromControl : MonoBehaviour {
    public Toggle T, R, S, Axis;
    public SliderWithEcho X, Y, Z;
    public TextMeshProUGUI ObjectName;

    private Transform mSelected;
    private Vector3 mPreviousSliderValues = Vector3.zero;

	// Use this for initialization
	void Start () {
        T.onValueChanged.AddListener(SetToTranslation);
        R.onValueChanged.AddListener(SetToRotation);
        S.onValueChanged.AddListener(SetToScaling);
        Axis.onValueChanged.AddListener(UpdateAxisVisibility);
        X.SetSliderListener(XValueChanged);
        Y.SetSliderListener(YValueChanged);
        Z.SetSliderListener(ZValueChanged);

        T.isOn = false;
        R.isOn = true;
        S.isOn = false;
        SetToRotation(true);
	}
	
    //---------------------------------------------------------------------------------
    // Initialize slider bars to specific function
    void SetToTranslation(bool v)
    {
        Vector3 p = ReadObjectXfrom();
        mPreviousSliderValues = p;
        X.InitSliderRange(-20, 20, p.x);
        Y.InitSliderRange(-20, 20, p.y);
        Z.InitSliderRange(-20, 20, p.z);
    }

    void SetToScaling(bool v)
    {
        Vector3 s = ReadObjectXfrom();
        mPreviousSliderValues = s;
        X.InitSliderRange(0.1f, 5, s.x);
        Y.InitSliderRange(0.1f, 5, s.y);
        Z.InitSliderRange(0.1f, 5, s.z);
    }

    void SetToRotation(bool v)
    {
        Vector3 r = ReadObjectXfrom();
        mPreviousSliderValues = r;
        X.InitSliderRange(-180, 180, r.x);
        Y.InitSliderRange(-180, 180, r.y);
        Z.InitSliderRange(-180, 180, r.z);
        mPreviousSliderValues = r;
    }
    //---------------------------------------------------------------------------------

    //---------------------------------------------------------------------------------
    // resopond to sldier bar value changes
    void XValueChanged(float v)
    {
        if (mSelected == null)
            return;
        Vector3 p = ReadObjectXfrom();
        // if not in rotation, next two lines of work would be wasted
            float dx = v - mPreviousSliderValues.x;
            mPreviousSliderValues.x = v;
        Quaternion q = Quaternion.AngleAxis(dx, Vector3.right);  // **- Please read the notes at the end
        p.x = v;
        UISetObjectXform(ref p, ref q);
    }
    
    void YValueChanged(float v)
    {
        if (mSelected == null)
            return;
        Vector3 p = ReadObjectXfrom();
            // if not in rotation, next two lines of work would be wasted
            float dy = v - mPreviousSliderValues.y;
            mPreviousSliderValues.y = v;
        Quaternion q = Quaternion.AngleAxis(dy, Vector3.up);    // **- Please read the notes at the end
        p.y = v;        
        UISetObjectXform(ref p, ref q);
    }

    void ZValueChanged(float v)
    {
        if (mSelected == null)
            return;
        Vector3 p = ReadObjectXfrom();
            // if not in rotation, next two lines of work would be wasterd
            float dz = v - mPreviousSliderValues.z;
            mPreviousSliderValues.z = v;
        Quaternion q = Quaternion.AngleAxis(dz, Vector3.forward); // **- Please read the notes at the end
        p.z = v;
        UISetObjectXform(ref p, ref q);
    }
    //---------------------------------------------------------------------------------

    // New object selected
    public void SetSelectedObject(Transform xform) {
        // If there is a previously selected object and the axis is toggled on, turn off its axis
        if (mSelected != null && Axis.isOn) {
            mSelected.gameObject.GetComponent<SceneNode>().turnOffAxis();
        }

        mSelected = xform;
        mPreviousSliderValues = Vector3.zero;
        if (xform != null) {
            ObjectName.text = "Selected:" + xform.name;
            // If the axis is toggled on, turn on the axis for the new object
            if (Axis.isOn) {
                mSelected.gameObject.GetComponent<SceneNode>().turnOnAxis();
            }
        } else {
            ObjectName.text = "Selected: none";
        }
        ObjectSetUI();
    }

    // Method to update the axis visibility based on the toggle state
    private void UpdateAxisVisibility(bool isOn) {
        if (mSelected == null) return;

        var axisControlScript = mSelected.gameObject.GetComponent<SceneNode>();
        if (isOn) {
            axisControlScript.turnOnAxis();
        } else {
            axisControlScript.turnOffAxis();
        }
    }

    public void ObjectSetUI()
    {
        Vector3 p = ReadObjectXfrom();
        X.SetSliderValue(p.x);  // do not need to call back for this comes from the object
        Y.SetSliderValue(p.y);
        Z.SetSliderValue(p.z);
    }

    private Vector3 ReadObjectXfrom()
    {
        Vector3 p;
        
        if (T.isOn)
        {
            if (mSelected != null)
                p = mSelected.localPosition;
            else
                p = Vector3.zero;
        }
        else if (S.isOn)
        {
            if (mSelected != null)
                p = mSelected.localScale;
            else
                p = Vector3.one;
        }
        else
        {
            p = Vector3.zero;
        }
        return p;
    }

    private void UISetObjectXform(ref Vector3 p, ref Quaternion q)
    {
        if (mSelected == null)
            return;

        if (T.isOn)
        {
            mSelected.localPosition = p;
        }
        else if (S.isOn)
        {
            mSelected.localScale = p;
        } else
        {
            mSelected.localRotation = mSelected.localRotation * q; // **- Please read the notes at the end
        }
    }
}