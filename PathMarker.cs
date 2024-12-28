using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PathMarker 
{
  public MapLocation location;
public float G;
public float H;
public float F;
public GameObject marker;
public PathMarker parent;

public PathMarker(MapLocation location,float g,float h, float f,GameObject marker,PathMarker parent) 
{
    this.location = location;
    this.G = g;
    this.H = h;
    this.F = f;
    this.marker = marker;
    this.parent = parent;

}
//!(this.GetType(Equals(obj.GetType())))
public override bool Equals(object obj) {
if (((obj) == null) || !this.GetType().Equals(Equals(obj.GetType())))
 { return false; }
  else {
return location.Equals(((PathMarker) obj).location);
}
}
public override int GetHashCode() {
return 0;
}
}
