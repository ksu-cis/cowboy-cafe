using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class ChiliCheeseFries : Side
    {
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 433;
                        break;
                    case (Size.Medium):
                        return 524;
                        break;
                    case (Size.Large):
                        return 610;
                        break;
                    default:
                        throw new NotImplementedException();
                }

            }
        }

        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 1.99;
                        break;
                    case (Size.Medium):
                        return 2.99;
                        break;
                    case (Size.Large):
                        return 3.99;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
}
