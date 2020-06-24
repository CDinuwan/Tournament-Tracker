using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    class SqlConnector : IDataConnection
    {
        //TODO- Make the CreatePrize method actually save to the database.
        /// <summary>
        /// Saves a new prize to database
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns>The prize information</returns>
        public PrizeModel CreatePrize(PrizeModel model) 
        {
            model.Id = 1;
            return model;
        }
    }
}
