using System;

class Program
{
    static void Main(string[] args)
    {
        Costume nurse = new();
        nurse.headWear = "face Mask";
        nurse.gloves = "latex";
        nurse.shoes = "orthopedic sneakers";
        nurse.upperGarment = "Scrubs";
        nurse.lowerGarment = "Scrubs";
        nurse.accessory = "Stethoscope";

        Costume detective = new();
        detective.headWear = "fedora";
        detective.gloves = "leather";
        detective.shoes = "loafers";
        detective.upperGarment = "trench coat";
        detective.lowerGarment = "slacks";
        detective.accessory = "magnifying glass";

        nurse.ShowWardrobe();
        detective.ShowWardrobe();
    }
}
