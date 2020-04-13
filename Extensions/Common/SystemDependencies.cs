using Microsoft.Extensions.DependencyInjection;
using ToDoListWebAPI.Extensions.Account;
using ToDoListWebAPI.Extensions.AccountStatus;
using ToDoListWebAPI.Extensions.Alert;
using ToDoListWebAPI.Extensions.AlertStatus;
using ToDoListWebAPI.Extensions.Category;
using ToDoListWebAPI.Extensions.Note;
using ToDoListWebAPI.Extensions.NoteStatus;
using ToDoListWebAPI.Extensions.NoteTask;
using ToDoListWebAPI.Extensions.NoteType;
using ToDoListWebAPI.Extensions.Notification;
using ToDoListWebAPI.Extensions.NotificationStatus;
using ToDoListWebAPI.Extensions.Share;
using ToDoListWebAPI.Extensions.ShareStatus;
using ToDoListWebAPI.Extensions.User;
using ToDoListWebAPI.Extensions.UserGroup;
using ToDoListWebAPI.Extensions.UserGroupStatus;
using ToDoListWebAPI.Extensions.UserStatus;
using ToDoListWebAPI.Extensions.UsersUserGroups;

namespace ToDoListWebAPI.Extensions.Common
{
    public static class SystemDependencies
    {
        public static void RegisterSystemDependencies(this IServiceCollection services)
        {
            services.RegisterAccountDependencies();
            services.RegisterAccountStatusDependencies();
            services.RegisterAlertDependencies();
            services.RegisterAlertStatusDependencies();
            services.RegisterCategoryDependencies();
            services.RegisterNoteDependencies();
            services.RegisterNoteStatusDependencies();
            services.RegisterNoteTaskDependencies();
            services.RegisterNoteTypeDependencies();
            services.RegisterNotificationDependencies();
            services.RegisterNotificationStatusDependencies();
            services.RegisterShareDependencies();
            services.RegisterShareStatusDependencies();
            services.RegisterUserDependencies();
            services.RegisterUserGroupDependencies();
            services.RegisterUserGroupStatusDependencies();
            services.RegisterUserStatusDependencies();
            services.RegisterUsersUserGroupsDependencies();
        }
    }
}
