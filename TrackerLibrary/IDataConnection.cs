using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
    }
}
