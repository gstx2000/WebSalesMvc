using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebSalesMvc.Models;
using SendGrid;
using SendGrid.Helpers.Mail;
using Newtonsoft.Json.Linq;


[Authorize]
public class UsersController : Controller
{
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;
    private readonly PasswordRecoveryService _passwordRecoveryService;
    public UsersController(UserManager<User> userManager, SignInManager<User> signInManager, PasswordRecoveryService passwordRecoveryService )
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _passwordRecoveryService = passwordRecoveryService;
    }

    [HttpGet]
    [AllowAnonymous]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    [AllowAnonymous]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            var user = new User { UserName = model.Email, Email = model.Email };
            var passwordValidator = new PasswordValidator<User>();
            var passwordValidationResult = await passwordValidator.ValidateAsync(_userManager, user, model.Password);
            if (passwordValidationResult.Succeeded)
            {
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Sua senha deve conter 6 letras, letras maiúsculas, minúsculas e um caractere especial.");
            }
        }
        return View(model);
    }


    [HttpGet]
    [AllowAnonymous]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    [AllowAnonymous]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError(string.Empty, "Usuário ou senha incorretos.");
        }

        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();

        return RedirectToAction("Login");
    }

    [HttpGet]
    [AllowAnonymous]
    public IActionResult PasswordRecovery()
    {
        return View();
    }

    [HttpPost]
    [AllowAnonymous]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> PasswordRecovery(PasswordRecoveryViewModel model)
    {
        if (ModelState.IsValid)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user != null)
            {
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var resetLink = Url.Action("ResetPassword", "Users", new { userId = user.Id, token = token }, Request.Scheme);

                await _passwordRecoveryService.SendEmailAsync(model.Email, "Recuperação de senha", $"Clique no link para redefinir sua senha: {resetLink}", "teste_app@gmail.com", "Equipe de suporte");

                return RedirectToAction("PasswordRecoveryConfirmation");
            }

        }

        ModelState.AddModelError(string.Empty, "Email inválido.");
        return View(model);
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> PasswordRecoveryConfirmation()
    {
       return View();   
    }

    [HttpPost]
    [AllowAnonymous]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
    {
        if (ModelState.IsValid)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            await _signInManager.SignInAsync(user, isPersistent: false);
            return RedirectToAction("Index", "Home");

        }

        ModelState.AddModelError(string.Empty, "Token inválido.");

        return View(model);
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> ResetPassword(string userId, string token)
    {
        var user = await _userManager.FindByIdAsync(userId);
        var isTokenValid = await _userManager.VerifyUserTokenAsync(user, _userManager.Options.Tokens.PasswordResetTokenProvider, "ResetPassword", token);

        if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(token))
        {
            return RedirectToAction("PasswordResetError");
        }

        if (user == null)
            return RedirectToAction("PasswordResetError");

        if (!isTokenValid)
        {
            return RedirectToAction("PasswordResetError");

        }

        return View();
    }

    [HttpGet]
    [AllowAnonymous]
    public IActionResult PasswordResetError()
    {
        return View();
    }

}


