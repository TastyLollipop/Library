using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Library
{
    public class Utils
    {
        //Fetches the IDs of the mods to rename
        public void FetchIndexesForDownload()
        {
            if (!Directory.Exists(Library._pathBox.Text))
            {
                Library.uiLogic.InvokeFunctionOn(UILogic.InvokeMode.showMessageBox, 0);
                Library.uiLogic.InvokeFunctionOn(UILogic.InvokeMode.changeStatusLabel, "Idle");
                Library.uiLogic.InvokeFunctionOn(UILogic.InvokeMode.toggleButtons, null);
                return;
            }

            string[] tempIDs = Directory.GetDirectories(Library._pathBox.Text);
            List<string> tempIDList = new List<string>();

            foreach (string id in tempIDs)
            {
                DirectoryInfo dir_info = new DirectoryInfo(id);
                tempIDList.Add(dir_info.Name);
            }

            Library.uiLogic.InvokeFunctionOn(UILogic.InvokeMode.changeProgressMax, tempIDList.Count());

            Library.networking.ids = tempIDList.ToArray();
            Library.networking.GetData();
        }

        //Shows message boxes to users
        public void ShowMessageBox(int indexID)
        {
            object[] fetchedData = Library._MessageBoxData.messageData[indexID];

            switch (indexID)
            {
                case 1:
                    MessageBox.Show(
                        (string)fetchedData[1] + Library.networking.skipedIDs, (string)fetchedData[0],
                        (MessageBoxButtons)fetchedData[2],
                        (MessageBoxIcon)fetchedData[3]
                    );
                    break;

                default:
                    MessageBox.Show(
                        (string)fetchedData[1], (string)fetchedData[0],
                        (MessageBoxButtons)fetchedData[2],
                        (MessageBoxIcon)fetchedData[3]
                    );
                    break;
            }
        }

        //Renames the folder to its valid name
        public void RenameFolder(string previousName, string newName)
        {
            string previousPath = Library._pathBox.Text + Path.DirectorySeparatorChar + previousName;
            string newPath = Library._pathBox.Text + Path.DirectorySeparatorChar + newName;

            try { Directory.Move(previousPath, newPath); }
            catch { Library.networking.skipedIDs++; }
        }
    }
}
