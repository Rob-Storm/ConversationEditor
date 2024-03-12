using System.ComponentModel;

namespace ConversationEditor.MVVM.Model
{
    public class Dialogue : INotifyPropertyChanged
    {
        private int nodeID;
        private string speaker;
        private string dialogueLine;
        private int nextNodeID;

        public int NodeID
        {
            get => nodeID;
            set
            {
                nodeID = value;
                OnPropertyChanged("NodeID");
            }
        }

        public string Speaker 
        { 
            get => speaker; 
            set
            { 
                speaker = value;
                OnPropertyChanged("Speaker");
            }
        }

        public string DialogueLine
        {
            get => dialogueLine;
            set
            {
                dialogueLine = value;
                OnPropertyChanged("DialogueLine");
            }
        }

        public int NextNodeID
        {
            get => nextNodeID;
            set
            {
                nextNodeID = value;
                OnPropertyChanged("NextNodeID");
            }
        }


        #region PropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
