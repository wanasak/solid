namespace liskov_substitution
{
    public class AppleNormal
    {
        public string GetColor()
        {
            return "Red";
        }
    }
    public class OrangeNormal : AppleNormal
    {
        public new string GetColor()
        {
            return "Orange";
        }
    }
}
