using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearts
{
    class CardComparer : IComparer<Card>
    {

            public int Compare(Card first, Card second)
            {
                if (first != null && second != null)
                {
                // We can compare both properties.
                //return ;
                return first.CompareTo(second);
            }

                if (first == null && second == null)
                {
                    // We can't compare any properties, so they are essentially equal.
                    return 0;
                }

                if (first != null)
                {
                    // Only the first instance is not null, so prefer that.
                    return -1;
                }

                // Only the second instance is not null, so prefer that.
                return 1;
            }
    }
}
