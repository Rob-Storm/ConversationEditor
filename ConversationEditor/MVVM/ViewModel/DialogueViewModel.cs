using ConversationEditor.MVVM.Model;
using System.Windows.Input;

namespace ConversationEditor.MVVM.ViewModel
{
    public class DialogueViewModel
    {
        private IList<Dialogue> _DialogueLines;

        public DialogueViewModel()
        {
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
