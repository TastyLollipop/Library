using System.Net;

namespace Library
{
    public class Networking
    {
        public string sourceURL = "https://steamcommunity.com/sharedfiles/filedetails/?id=";
        public string[] ids;
        public int skipedIDs;

        //Gets all the data needed from the URL provided
        public void GetData()
        {
            skipedIDs = 0;

            using (WebClient webClient = new WebClient())
            {
                foreach (string id in ids)
                {
                    string urlToFetch = string.Concat(sourceURL, id);

                    if (char.IsDigit(id[0]))
                    {
                        string data = webClient.DownloadString(urlToFetch);

                        if (data.Contains("workshopItemTitle"))
                        {
                            int dataLocationIndex = data.IndexOf("workshopItemTitle");
                            data = data.Remove(0, dataLocationIndex);
                            data = data.Split('<')[0];
                            data = data.Remove(0, 19);

                            Library.utils.RenameFolder(id, data);
                        }

                        else skipedIDs++;
                    }

                    else skipedIDs++;

                    //Advances the current UI status
                    Library.uiLogic.InvokeFunctionOn(UILogic.InvokeMode.changeProgressValue, Library._progressBar.Value + 1);
                    Library.uiLogic.InvokeFunctionOn(UILogic.InvokeMode.changeStatusLabel, Library._progressBar.Value + "/" + Library._progressBar.Maximum);
                }
            }

            //Show user that it finished and reset everything for next try
            Library.uiLogic.InvokeFunctionOn(UILogic.InvokeMode.showMessageBox, 1);
            Library.uiLogic.InvokeFunctionOn(UILogic.InvokeMode.changeProgressValue, 0);
            Library.uiLogic.InvokeFunctionOn(UILogic.InvokeMode.changeProgressMax, 0);
            Library.uiLogic.InvokeFunctionOn(UILogic.InvokeMode.changeStatusLabel, "Idle");
            Library.uiLogic.InvokeFunctionOn(UILogic.InvokeMode.toggleButtons, null);
        }
    }
}
