using UnityEngine;
using System.Collections.Generic;

public enum Element { water, wood, fire, earth, metal, holy };

public struct ElementAttributes{
  public HashSet<Element> weakness;
  public HashSet<Element> strength;

  public ElementAttributes(HashSet<Element> weakness, HashSet<Element> strength){
    this.weakness = weakness;
    this.strength = strength;
  }
}

static class Reference {
  public static HashSet<Element> WeaknessWater = new HashSet<Element> { Element.earth, Element.holy };
  public static HashSet<Element> WeaknessFire  = new HashSet<Element> { Element.water, Element.holy };
  public static HashSet<Element> WeaknessHoly  = new HashSet<Element> {};

  public static HashSet<Element> StrengthWater = new HashSet<Element> { Element.fire };
  public static HashSet<Element> StrengthFire  = new HashSet<Element> { Element.wood };
  public static HashSet<Element> StrengthHoly  = new HashSet<Element> { Element.water, Element.wood, Element.fire, Element.metal, Element.earth};

  public static Dictionary<Element, ElementAttributes> elements =
    new Dictionary<Element, ElementAttributes>{
    { Element.water, new ElementAttributes(WeaknessWater, StrengthWater) },
    { Element.fire , new ElementAttributes(WeaknessFire,  StrengthFire) },
    { Element.holy , new ElementAttributes(WeaknessHoly,  StrengthHoly) }
  };

  //TODO the other elements
}