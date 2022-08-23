using System;
using System.Windows.Forms;

namespace Library
{
    public class UILogic
    {
        public enum InvokeMode { changeStatusLabel, changeProgressValue, changeProgressMax, toggleButtons, showMessageBox }

        //Allows actions to be called from other threads
        public void InvokeFunctionOn(InvokeMode mode, Object value)
        {
            Action safeInvoke = null;

            switch (mode)
            {
                case InvokeMode.changeStatusLabel:
                    safeInvoke = delegate { ChangeStatusLabel((string)value); };
                    Library._statusLabel.Invoke(safeInvoke);
                    break;

                case InvokeMode.changeProgressValue:
                    safeInvoke = delegate { ChangeProgressBarFill((int)value); };
                    Library._progressBar.Invoke(safeInvoke);
                    break;

                case InvokeMode.changeProgressMax:
                    safeInvoke = delegate { ChangeProgressBarMax((int)value); };
                    Library._progressBar.Invoke(safeInvoke);
                    break;

                case InvokeMode.toggleButtons:
                    safeInvoke = delegate { ToggleUI(); };
                    Library._browseButton.Invoke(safeInvoke);
                    break;

                case InvokeMode.showMessageBox:
                    safeInvoke = delegate { ShowMessageBox((int) value); };
                    Library._progressBar.Invoke(safeInvoke);
                    break;
            }
        }

        //Changes the status label text
        public void ChangeStatusLabel(string newStatus) { Library._statusLabel.Text = "Status: " + newStatus; }

        //Changes the progress bar fill value
        public void ChangeProgressBarFill(int newValue) { Library._progressBar.Value = newValue; }

        //Changes the progress bar maximum value
        public void ChangeProgressBarMax(int newValue) { Library._progressBar.Maximum = newValue; }

        //Toggles UI On or Off
        public void ToggleUI()
        {
            Library._browseButton.Enabled = !Library._browseButton.Enabled;
            Library._convertButton.Enabled = !Library._convertButton.Enabled;

            Library._progressBar.Enabled = !Library._progressBar.Enabled;
            Library._pathBox.Enabled = !Library._pathBox.Enabled;
        }

        //Shows message boxes to users
        public void ShowMessageBox(int indexID)
        {
            object[] fetchedData = Library.messageBoxData.messageData[indexID];

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
    }
}
