using Infrastructure.Entities;
using WebApp.ViewModels.Views;

public class UserFactory
{
    public UserEntity ReturnUserEntity(SignUpViewModel viewModel)
    {
        var userEntity = new UserEntity
        {
            FirstName = viewModel.FirstName,
            LastName = viewModel.LastName,
            Email = viewModel.Email,
            UserName = viewModel.Email,
        };

        return userEntity;
    }
}