using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPHT.Pages;
using ProjectPHT.ViewModels;

namespace ProjectPHT
{
    public static class PHTConfig
    {
        private static  UserViewModel _userViewModel;
        public static UserViewModel userViewModel 
        { 
            get 
            { 
                if (_userViewModel == null)
                {
                    _userViewModel = new UserViewModel();
                }
                return _userViewModel;
            } 
        }
        private static  LoginViewModel _loginViewModel;
        public static LoginViewModel loginViewModel
        {
            get 
            {
                if (_loginViewModel == null)
                {
                    _loginViewModel = new LoginViewModel();
                }
                return _loginViewModel;
            }
        }
        private static  SignUpViewModel _signUpViewModel;

        public static SignUpViewModel signUpViewModel
        {
            get
            {
                if (_signUpViewModel == null)
                {
                    _signUpViewModel = new SignUpViewModel();
                }
                return _signUpViewModel;
            }
        }

        private static  ProfileSettingsViewModel _profileSettingsViewModel;

        public static ProfileSettingsViewModel profileSettingsViewModel
        {
            get
            {
                if (_profileSettingsViewModel == null)
                {
                    _profileSettingsViewModel = new ProfileSettingsViewModel();
                }
                return _profileSettingsViewModel;
            }
        }
        private static  ContactSupportViewModel _contactSupportViewModel;
        public static ContactSupportViewModel contactSupportViewModel
        {
            get
            {
                if (_contactSupportViewModel == null)
                {
                    _contactSupportViewModel = new ContactSupportViewModel();
                }
                return _contactSupportViewModel;
            }
        }
        private static  DailyHealthMetrixEntryViewModel _dailyHealthMetrixEntryViewModel;
        public static DailyHealthMetrixEntryViewModel dailyHealthMetrixEntryViewModel
        {
            get
            {
                if (_dailyHealthMetrixEntryViewModel == null)
                {
                    _dailyHealthMetrixEntryViewModel = new DailyHealthMetrixEntryViewModel();
                }
                return _dailyHealthMetrixEntryViewModel;
            }
        }

        private static  DeviceSyncViewModel _deviceSyncViewModel;
        public static DeviceSyncViewModel deviceSyncViewModel
        {
            get
            {
                if (_deviceSyncViewModel == null)
                {
                    _deviceSyncViewModel = new DeviceSyncViewModel();
                }
                return _deviceSyncViewModel;
            }
        }
        public static HealthHistoryViewModel _healthHistoryViewModel;
        public static HealthHistoryViewModel healthHistoryViewModel
        {
            get
            {
                if (_healthHistoryViewModel == null)
                {
                    _healthHistoryViewModel = new HealthHistoryViewModel();
                }
                return _healthHistoryViewModel;
            }
        }

        private static  HealthInsightViewModel _healthInsightViewModel;
        public static HealthInsightViewModel healthInsightViewModel
        {
            get
            {
                if (_healthInsightViewModel == null)
                {
                    _healthInsightViewModel = new HealthInsightViewModel();
                }
                return _healthInsightViewModel;
            }
        }
        private static  GoalsViewModel _goalsViewModel;
        public static GoalsViewModel goalsViewModel
        {
            get
            {
                if (_goalsViewModel == null)
                {
                    _goalsViewModel = new GoalsViewModel();
                }
                return _goalsViewModel;
            }
        }
        private static  NotificationViewModel _notificationViewModel;
        public static NotificationViewModel notificationViewModel
        {
            get
            {
                if (_notificationViewModel == null)
                {
                    _notificationViewModel = new NotificationViewModel();
                }
                return _notificationViewModel;
            }
        }
        private static  LoginWindow _loginWindow;
        public static LoginWindow loginWindow
        {
            get
            {
                if (_loginWindow == null)
                {
                    _loginWindow = new LoginWindow();
                }
                return _loginWindow;
            }
        }
        private static  SignUpWindow _signUpWindow;
        public static SignUpWindow signUpWindow
        {
            get
            {
                if (_signUpWindow == null)
                {
                    _signUpWindow = new SignUpWindow();
                }
                return _signUpWindow;
            }
        }
        private static  HomePageWindow _homePageWindow;
        public static HomePageWindow homePageWindow
        {
            get
            {
                if (_homePageWindow == null)
                {
                    _homePageWindow = new HomePageWindow();
                }
                return _homePageWindow;
            }
        }
        private static  DailyHealthMetrixEntryWindow _dailyHealthMetrixEntryWindow;
        public static DailyHealthMetrixEntryWindow dailyHealthMetrixEntryWindow
        {
            get
            {
                if (_dailyHealthMetrixEntryWindow == null)
                {
                    _dailyHealthMetrixEntryWindow = new DailyHealthMetrixEntryWindow();
                }
                return _dailyHealthMetrixEntryWindow;
            }
        }
        private static  DeviceIntegrationWindow _deviceIntegrationWindow;
        public static DeviceIntegrationWindow deviceIntegrationWindow
        {
            get
            {
                if (_deviceIntegrationWindow == null)
                {
                    _deviceIntegrationWindow = new DeviceIntegrationWindow();
                }
                return _deviceIntegrationWindow;
            }
        }
        private static  HealthGoalsWindow _healthGoalsWindow;
        public static HealthGoalsWindow healthGoalsWindow
        {
            get
            {
                if (_healthGoalsWindow == null)
                {
                    _healthGoalsWindow = new HealthGoalsWindow();
                }
                return _healthGoalsWindow;
            }
        }
        private static  HealthHistoryWindow _healthHistoryWindow;
        public static HealthHistoryWindow healthHistoryWindow
        {
            get
            {
                if (_healthHistoryWindow == null)
                {
                    _healthHistoryWindow = new HealthHistoryWindow();
                }
                return _healthHistoryWindow;
            }
        }
        private static  AddGoalWindow _frmAddGoal;
        public static AddGoalWindow frmAddGoal
        {
            get
            {
                if (_frmAddGoal == null)
                {
                    _frmAddGoal = new AddGoalWindow();
                }
                return _frmAddGoal;
            }
        }
        private static  EditGoalWindow _frmEditGoalWindow;
        public static EditGoalWindow frmEditGoalWindow
        {
            get
            {
                if (_frmEditGoalWindow == null)
                {
                    _frmEditGoalWindow = new EditGoalWindow();
                }
                return _frmEditGoalWindow;
            }
        }
        private static  HealthInsightWindow _healthInsightWindow;
        public static HealthInsightWindow healthInsightWindow
        {
            get
            {
                if (_healthInsightWindow == null)
                {
                    _healthInsightWindow = new HealthInsightWindow();
                }
                return _healthInsightWindow;
            }
        }
        private static  ProfileSettingsWindow _profileSettingsWindow;
        public static ProfileSettingsWindow profileSettingsWindow
        {
            get
            {
                if (_profileSettingsWindow == null)
                {
                    _profileSettingsWindow = new ProfileSettingsWindow();
                }
                return _profileSettingsWindow;
            }
        }
        private static  UserDashBoardWindow _userDashBoardWindow;
        public static UserDashBoardWindow userDashBoardWindow
        {
            get
            {
                if (_userDashBoardWindow == null)
                {
                    _userDashBoardWindow = new UserDashBoardWindow();
                }
                return _userDashBoardWindow;
            }
        }
        private static  AdminDashboardWindow _adminDashboardWindow;
        public static AdminDashboardWindow adminDashboardWindow
        {
            get
            {
                if (_adminDashboardWindow == null)
                {
                    _adminDashboardWindow = new AdminDashboardWindow();
                }
                return _adminDashboardWindow;
            }
        }
        private static  UserManagementWindow _userManagementWindow;
        public static UserManagementWindow userManagementWindow
        {
            get
            {
                if (_userManagementWindow == null)
                {
                    _userManagementWindow = new UserManagementWindow();
                }
                return _userManagementWindow;
            }
        }
        private static  SystemPerformanceWindow _systemPerformanceWindow;
        public static SystemPerformanceWindow systemPerformanceWindow
        {
            get
            {
                if (_systemPerformanceWindow == null)
                {
                    _systemPerformanceWindow = new SystemPerformanceWindow();
                }
                return _systemPerformanceWindow;
            }
        }
        private static  PlatformAnalysisWindow _platformAnalysisWindow;
        public static PlatformAnalysisWindow platformAnalysisWindow
        {
            get
            {
                if (_platformAnalysisWindow == null)
                {
                    _platformAnalysisWindow = new PlatformAnalysisWindow();
                }
                return _platformAnalysisWindow;
            }
        }
        private static  ContactSettings _contactSupportWindow;
        public static ContactSettings contactSupportWindow
        {
            get
            {
                if (_contactSupportWindow == null)
                {
                    _contactSupportWindow = new ContactSettings();
                }
                return _contactSupportWindow;
            }
        }

        private static CreateUserWindow _createUserWindow;
        public static CreateUserWindow createUserWindow
        {
            get
            {
                if (_createUserWindow == null)
                {
                    _createUserWindow = new CreateUserWindow();
                }
                return _createUserWindow;
            }
        }

        private static UpdateUserWindow _updateUserWindow;
        public static UpdateUserWindow updateUserWindow
        {
            get
            {
                if (_updateUserWindow == null)
                {
                    _updateUserWindow = new UpdateUserWindow();
                }
                return _updateUserWindow;
            }
        }
        //static PHTConfig()
        //{
        //    userViewModel = new UserViewModel();
        //    loginViewModel = new LoginViewModel();
        //    //signUpViewModel = new SignUpViewModel();
        //    profileSettingsViewModel = new ProfileSettingsViewModel();
        //    contactSupportViewModel = new ContactSupportViewModel();
        //    dailyHealthMetrixEntryViewModel = new DailyHealthMetrixEntryViewModel();
        //    deviceSyncViewModel = new DeviceSyncViewModel();
        //    healthHistoryViewModel = new HealthHistoryViewModel();
        //    //healthInsightViewModel = new HealthInsightViewModel();
        //    //goalsViewModel = new GoalsViewModel();
        //    //notificationViewModel = new NotificationViewModel();
        //    loginWindow = new LoginWindow();
        //    //signUpWindow = new SignUpWindow();
        //    homePageWindow = new HomePageWindow();
        //   // dailyHealthMetrixEntryWindow = new DailyHealthMetrixEntryWindow();
        //    deviceIntegrationWindow = new DeviceIntegrationWindow();
        //    //healthGoalsWindow = new HealthGoalsWindow();
        //    //frmAddGoal = new AddGoalWindow();
        //    //frmEditGoalWindow = new EditGoalWindow();
        //    healthHistoryWindow = new HealthHistoryWindow();
        //    //healthInsightWindow = new HealthInsightWindow();
        //    profileSettingsWindow = new ProfileSettingsWindow();
        //    userDashBoardWindow = new UserDashBoardWindow();
        //    //adminDashboardWindow = new AdminDashboardWindow();
        //    //userManagementWindow = new UserManagementWindow();
        //    //systemPerformanceWindow = new SystemPerformanceWindow();
        //    //platformAnalysisWindow = new PlatformAnalysisWindow();
        //    //contactSupportWindow = new ContactSettings();
        //}
    }
}

