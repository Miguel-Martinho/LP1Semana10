using System.Collections.Generic;

namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {
        private bool order;
        public CompareByName(bool order = true)
        {
            this.order = order;
        }
        public int Compare(Player x, Player y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
}