
namespace MonkeyFinder.ViewModel;

public partial class BaseViewModel : ObservableObject, INotifyPropertyChanged
{
    //bool isBusy;
    //public bool IsBusy
    //{
    //    get => isBusy;
    //    set
    //    {
    //        if (isBusy == value)
    //            return;
    //        OnPropertyChanged();

    //        OnPropertyChanged(nameof(IsNotBusy));
    //    }
    //}

    [ObservableProperty]
    string title;

    //public bool IsNotBusy => !IsBusy;

    public event PropertyChangedEventHandler PropertyChanged;

    public void OnPropertyChanged([CallerMemberName] string name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
