using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAcces
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";

        public PrizeModel CreatePrize(PrizeModel model)
        { 
            //TODO - WTF?
            //Load the text file and convert the text to List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            //Find the max id 
            int currentId =  1;
            if(prizes.Count > 0) 
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            //add the new record with the new ID (max+1)
            prizes.Add(model);

            //convert the prizes to list<string>
            //save the list<string> tothe text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }
    }
}
