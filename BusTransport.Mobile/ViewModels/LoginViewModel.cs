using BusTransport.Mobile.Services;
using MvvmHelpers;
using System.ComponentModel;
using System.Windows.Input;

namespace BusTransport.Mobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public ICommand LoginCommand { get; }
        public ICommand ReportProblemCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLogin);
            ReportProblemCommand = new Command(OnReportProblem);
        }

        private void OnLogin()
        {
            // Simulate login logic
            // Navigate to MainPage upon successful login
        }

        private void OnReportProblem()
        {
            // Navigate to ReportProblemPage
        }
    }
}
