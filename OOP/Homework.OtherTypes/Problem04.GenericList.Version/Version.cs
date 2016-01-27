namespace Problem04.GenericList.Version
{
    using System;

    [AttributeUsage(AttributeTargets.Class |
        AttributeTargets.Struct |
        AttributeTargets.Enum |
        AttributeTargets.Interface |
        AttributeTargets.Method)]
    public class VersionAttribute : Attribute
    {
        public VersionAttribute(int major, int minor)
        {
            this.Minor = minor;
            this.Major = major;
        }

        public int Minor { get; set; }

        public int Major { get; set; }

        public override string ToString()
        {
            return string.Format("{0}.{1}", this.Major, this.Minor);
        }
    }
}
