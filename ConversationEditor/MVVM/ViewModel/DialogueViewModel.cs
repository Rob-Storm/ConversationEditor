using ConversationEditor.MVVM.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace ConversationEditor.MVVM.ViewModel
{
    public class DialogueViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Dialogue> _DialogueLines;

        public DialogueViewModel()
        {
            _DialogueLines = new ObservableCollection<Dialogue>();
        }

        public ObservableCollection<Dialogue> DialogueLines 
        { 
            get => _DialogueLines;
            set
            {
                _DialogueLines = value;
                OnPropertyChanged("DialogueLines");
            }
        }
        private ICommand mUpdater;

        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null) mUpdater = new Updater(this);
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class Updater : ICommand
    {
        private DialogueViewModel _viewModel;

        public Updater(DialogueViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            if (parameter != null)
            {
                if (parameter.ToString() == "AddNewLine")
                {
                    _viewModel.DialogueLines.Add(new Dialogue { NodeID = 0, Speaker = "Speaker", DialogueLine = "Dialogue", NextNodeID = 1 });
                    // Notify the view of the change
                    OnPropertyChanged(nameof(_viewModel.DialogueLines));
                }
                else if (parameter.ToString() == "ClearLines")
                {
                    _viewModel.DialogueLines.Clear();
                    // Notify the view of the change
                    OnPropertyChanged(nameof(_viewModel.DialogueLines));
                }
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
