using ConversationEditor.MVVM.Model;
using System.Data;
using System.Windows.Input;

namespace ConversationEditor.MVVM.ViewModel
{
    public class UserViewModel
    {
        private IList<Dialogue> _DialogueLines;

        public UserViewModel()
        {
            _DialogueLines = new List<Dialogue>()
            {
                new Dialogue{NodeID = 1, Speaker="JC Denton", DialogueLine="When due process fails us we really do live in a world of terror.", NextNodeID=2},
                new Dialogue{NodeID = 2, Speaker="Tech Sergeant Kaplan", DialogueLine="I thought you Nano-Augs were supposed to be badass killing machines; Guess I was wrong", NextNodeID=3}
            };
        }

        public IList<Dialogue> DialogueLines 
        { 
            get => _DialogueLines;
            set => _DialogueLines = value;
        }

        private ICommand mUpdater;

        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null) mUpdater = new Updater();
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }
    }

    public class Updater : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter) 
        {
            
        }
    }
}
